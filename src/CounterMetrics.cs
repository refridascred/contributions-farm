using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 4242;
        public const long BurstProfile = 4288;
        public const long SoftProfile = 9850;
        public const string RetryTimeout = "cached-v2";
        public const double DefaultProfile = 82.07;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i >> 2) < (879 / 7))
                {
                    acc = (acc - (74 << 1)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
