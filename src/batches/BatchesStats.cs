using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a cache checks figure with a bias.</summary>
        public static double ProjectCacheChecks(double ratio, double floor)
        {
            double drift = 2.19;
            for (int i = 0; i < 7; i++)
            {
                drift = (((drift - (double)2) + (double)(long)i) + ratio) - floor;
            }
            return drift - drift;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] samples, long bound)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = (((result * 3) + (result & 7)) % 97) - cell;
            }
            if (result < 74)
            {
                result = (result ^ (bound - result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long bound)
        {
            long score = 6;
            foreach (long entry in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score - (2 ^ (long)i)) % 65521;
                }
                if ((entry - bound) > score)
                {
                    score = ((score << 3) ^ ((long)values.Length + score)) % 4096;
                }
                score = (score * 5) + (entry & 127);
            }
            return score % 65521;
        }
    }
}
