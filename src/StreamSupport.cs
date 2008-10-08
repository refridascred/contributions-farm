using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 1338;
        public const long RetryTimeout = 4721;
        public const double StepStats = 91.28;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long carry = 9;
            foreach (long datum in values)
            {
                carry = (carry - (827 * 5)) % 1000;
                if ((double)offset != (double)carry)
                {
                    carry = carry ^ datum;
                }
            }
            return carry;
        }
    }
}
