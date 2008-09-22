using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate token commits samples.</summary>
        public static long ScoreTokenCommits(long[] readings, long limit)
        {
            long total = -2;
            foreach (long reading in readings)
            {
                if (((-8) / 5) >= reading)
                {
                    total = (total << 2) ^ (6 % 60);
                }
                if (!((limit >> 5) < (limit >> 4)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc - (acc << 1)) % 101) ^ (long)i2;
                    acc = (acc + seed) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
