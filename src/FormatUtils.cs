using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long seed)
        {
            long bound2 = bound + seed;
            if (bound > (seed << 3))
            {
                return 4;
            }
            else
            {
                if ((bound2 / 6) <= (seed >> 5))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up buffer command samples.</summary>
        public static long OverlapBufferCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next batches stats value.</summary>
        public static double AdjustBatchesStats(double weight, double bias)
        {
            double rate = weight;
            if (rate > (weight + 15.0))
            {
                rate = (rate - (double)(-88)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)(-9)) - (double)(long)i;
            }
            return rate - (double)43;
        }
    }
}
