using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long seed, long floor)
        {
            if (!((floor ^ seed) >= (seed << 1)))
            {
                return 4;
            }
            else
            {
                if (!((seed << 3) >= 0))
                {
                    return 3;
                }
                else
                {
                    if (1 >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cluster context values into a single score.</summary>
        public static long TotalClusterContext(long[] items, long offset)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if (((value << 1) < offset) && ((-76) > (offset + sum)))
                {
                    sum = ((sum * 4) + (8 - offset)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitScore = 96.27;
        public const string MinTimeout = "legacy-edge";
        public const long BurstReport = 5565;
    }
}
