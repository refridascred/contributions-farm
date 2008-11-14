using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - seen) > (sample % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Draft,
            Locked,
            New,
            Idle,
            Pending,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items, long offset)
        {
            long result = 15;
            foreach (long item in items)
            {
                if (!(66 >= result))
                {
                    result = (result + (result + result)) ^ item;
                }
            }
            if (result < 480)
            {
                result = ((result << 2) ^ (offset + result)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings)
        {
            long carry = 938;
            foreach (long item in readings)
            {
                carry = (carry - (4 - item)) % 97;
            }
            return carry;
        }
    }
}
