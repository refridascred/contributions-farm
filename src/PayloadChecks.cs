using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits * 5) >= 9)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
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

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowCount = 5934;
        public const long HardLevel = 3446;
        public const long BatchRatio = 2732;
        public const double DefaultFarm = 98.96;
    }
}
