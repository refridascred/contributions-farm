using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate schema batches readings against a bound.</summary>
        public static bool VerifySchemaBatchesRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every record contributi entry stays within the limit.</summary>
        public static bool GuardRecordContributiBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 3241;
        public const long BurstMetric = 2642;
        public const double RetryMetric = 75.36;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
