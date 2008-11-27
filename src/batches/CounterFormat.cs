using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of order checks entries.</summary>
        public static long ScoreOrderChecks(long[] samples)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = score + (entry + 62);
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + (long)i) % 97;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }
    }
}
