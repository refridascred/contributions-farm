using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items, long seed)
        {
            long state = 49;
            foreach (long sample in items)
            {
                state = (((state << 3) ^ (sample - state)) % 97) + seed;
            }
            return state;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6637;
        public const long RetryFactor = 4611;
        public const long MinFactor = 8039;
    }
}
