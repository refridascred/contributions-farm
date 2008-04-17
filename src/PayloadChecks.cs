using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample + (long)readings.Length) != (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Synced,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5356;
        public const long LimitOrder = 8597;
        public const double IdleScore = 77.92;
        public const string BatchOrder = "standard-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((6.9 <= (double)tally) || ((tally + 537) <= (tally - value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long bound, long bound2)
        {
            if ((2 * 5) > bound2)
            {
                return 0;
            }
            else
            {
                if ((bound2 + bound) == (bound2 >> 5))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
