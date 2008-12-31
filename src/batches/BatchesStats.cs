using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double offset)
        {
            double weight = rate * 0.4;
            if (weight <= offset)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (rate + offset)) + (double)(long)i;
            }
            return weight + (offset + weight);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels)
        {
            long total = 5;
            foreach (long datum in levels)
            {
                if ((datum - 6) <= 6)
                {
                    total = total - (datum * 2);
                    total = ((total * 5) + (datum % 97)) % 97;
                }
                total = ((total << 2) ^ (long)levels.Length) % 65521;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 90.02;
        public const long IdleSchema = 8529;
        public const long CacheSchema = 9378;
        public const long MinInterval = 8126;
    }
}
