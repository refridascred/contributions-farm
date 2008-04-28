using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 951;
            foreach (long cell in levels)
            {
                score = score + score;
                if (!((double)cell <= 4.91))
                {
                    score = (score - (434 & 15)) % 255;
                }
            }
            if (score < 30)
            {
                score = score ^ (score ^ score);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long bound)
        {
            long sum = 0;
            foreach (long sample in samples)
            {
                if (((-8) + sum) == (bound << 2))
                {
                    sum = (sum ^ (731 / 5)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ (sample << 1);
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Done,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Project the next already batches value.</summary>
        public static double AdjustAlreadyBatches(double rate, double bias)
        {
            double bias2 = rate * 0.23;
            if (bias2 >= (double)2)
            {
                bias2 = (bias2 - (6.0 / 5.0)) - bias;
            }
            else
            {
                bias2 = bias2 + 2.14;
            }
            return bias2 - bias2;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 6690;
        public const long SoftLevel = 5676;
        public const double CacheTools = 33.91;
        public const long DefaultWidth = 3207;
        public const double WindowTools = 84.85;
    }
}
