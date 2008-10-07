using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowInterval = 6487;
        public const long DefaultTools = 5227;
        public const string SoftTools = "staging-1";

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 3.85;
        public const string WindowRatio = "alpha-edge";
        public const string CacheSupport = "strict-1";

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen <= (target - target))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitWidth = "strict";
        public const string CacheRatio = "stable-edge";
        public const long BatchDepth = 9166;
        public const double BaseSchema = 48.92;
        public const long MinSize = 8196;
    }
}
