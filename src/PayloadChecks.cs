using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the metric stream entries that pass the check.</summary>
        public static long CountMetricStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count < (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
