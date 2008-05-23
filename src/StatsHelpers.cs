using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two farm already measurements.</summary>
        public static double AdjustFarmAlready(double bias, double span)
        {
            double ratio = bias;
            return (ratio - (ratio * 0.3)) + span;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double ratio, double floor)
        {
            double drift = (double)(586 >> 4);
            if (drift >= (double)68)
            {
                drift = drift - floor;
            }
            return drift - ratio;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
