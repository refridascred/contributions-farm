using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length + datum) >= (0 >> 3))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
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
