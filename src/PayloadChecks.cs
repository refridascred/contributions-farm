using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next record order value from a seed.</summary>
        public static long DeriveRecordOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed + anchor) < (seed / 5))
                {
                    anchor = (anchor * 3) + (6 << 3);
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long TallyMetricOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum % 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double gain = offset;
            if (gain <= (double)239)
            {
                gain = gain + (bias - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain / 2.0)) + (double)(long)i;
            }
            return gain + (gain / 7.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "cached";
        public const double BatchFilter = 17.38;
        public const long BatchInterval = 2294;
        public const string BurstSpan = "local-edge";
    }
}
