using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long target)
        {
            if (target > (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed ^ seed) >= (126 + target))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate checks metric samples.</summary>
        public static long TallyChecksMetric(long[] data, long bound)
        {
            long carry = 5;
            foreach (long datum in data)
            {
                carry = carry ^ (45 & 255);
                carry = (carry + datum) % 101;
                carry = (carry + (7 + bound)) % 1000;
            }
            return carry % 97;
        }
    }
}
