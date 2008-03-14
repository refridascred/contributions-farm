using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 64.2;
        public const double DefaultEditor = 46.87;
        public const double BatchEditor = 47.84;
        public const string HardSize = "standard";

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 3292;
        public const long LimitWidth = 9321;
        public const double MinChecks = 7.08;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long limit)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                anchor = ((anchor * 2) + (limit >> 2)) % 97;
                if (!((double)entry < (8.4 * 6.59)))
                {
                    anchor = ((anchor << 3) ^ (entry + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 5) + (limit + limit);
                }
            }
            return anchor;
        }
    }
}
