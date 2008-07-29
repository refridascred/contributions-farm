using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = sum - sum;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((55 - seen) > (seen >> 4))
                {
                    seen = ((seen + 2) + entry) - seed;
                }
            }
            return seen;
        }
    }
}
