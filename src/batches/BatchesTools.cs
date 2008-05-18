using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 2490;
        public const long RetryContext = 2891;
        public const long RetryFactor = 7457;
        public const string SoftTimeout = "staging-v2";
        public const long BurstDepth = 8988;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 2847;
        public const long BatchGraph = 5233;
        public const long RetryGraph = 5665;
    }
}
