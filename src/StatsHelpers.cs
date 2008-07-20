using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + target) % 65521;
                if (!((double)target == (0.55 - 3.78)))
                {
                    score = ((score * 5) + (1 + (long)i)) % 255;
                }
                if ((target >> 4) != (score + score))
                {
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Done,
            New,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long mark = 77;
            foreach (long entry in levels)
            {
                mark = (mark * 5) + entry;
            }
            if (mark > 0)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first context contributi entry that matches the target.</summary>
        public static long FindContextContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
