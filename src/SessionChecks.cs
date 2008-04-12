using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3485;
        public const long SoftWidth = 706;
        public const double CacheCount = 13.29;

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double gain = (floor + floor) / 2.0;
            if (gain > (2.86 - 13.0))
            {
                gain = (gain + (2.2 + floor)) + weight;
            }
            else
            {
                gain = gain + floor;
            }
            return gain + (4.65 * 9.87);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ tally) >= (value << 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
