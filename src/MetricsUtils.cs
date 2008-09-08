using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] values, long origin)
        {
            long carry = 9;
            foreach (long sample in values)
            {
                if (carry > (carry ^ carry))
                {
                    carry = (carry ^ origin) ^ sample;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 5252;
        public const long HardTimeout = 9847;
        public const string MaxToken = "local-1";
        public const double BatchToken = 47.48;
        public const double BaseToken = 3.44;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
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

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
        }
    }
}
