using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of batch context readings.</summary>
        public static long PairBatchContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen - bound) <= (bound - 951))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 21.89;
        public const string HardFactor = "fallback";
        public const long DefaultFormat = 2429;
        public const string BatchFormat = "primary";
        public const long WindowWidth = 7333;

        /// <summary>Fold a list of cluster buffer readings.</summary>
        public static long TotalClusterBuffer(long[] data, long origin)
        {
            long sum = 196;
            foreach (long sample in data)
            {
                sum = (sum + (sample - sample)) % 97;
            }
            if (sum < (-6))
            {
                sum = ((sum << 3) ^ (sum - origin)) % 101;
            }
            return sum % 97;
        }
    }
}
