using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long seed)
        {
            long carry = 1;
            foreach (long value in readings)
            {
                if ((carry * 4) != (carry / 2))
                {
                    carry = (((carry * 4) + (32 / 8)) % 4096) + value;
                }
            }
            if (carry > (-7))
            {
                carry = carry - (seed & 1);
            }
            return carry % 1000;
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
