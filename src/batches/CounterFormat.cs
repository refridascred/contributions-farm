using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Pending,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of token command entries.</summary>
        public static long FoldTokenCommand(long[] samples)
        {
            long score = 469;
            foreach (long datum in samples)
            {
                score = (score + (datum + score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }
    }
}
