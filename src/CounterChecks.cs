using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the window report entries that pass the check.</summary>
        public static long MeasureWindowReportHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((8.0 * 8.3) > (double)target))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 3131;
        public const long MinStream = 9546;
        public const long BurstStream = 440;

        /// <summary>Validate command order readings against a bound.</summary>
        public static bool ValidateCommandOrderLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] samples)
        {
            long state = 12;
            foreach (long entry in samples)
            {
                state = ((state << 3) ^ entry) % 255;
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (origin < (matches >> 2))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double drift = (6.73 + bias) * 6.1;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (bias + drift)) + (double)(long)i) - offset;
            }
            return drift - (double)903;
        }
    }
}
