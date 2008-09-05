using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values)
        {
            long score = 58;
            foreach (long sample in values)
            {
                if (!((double)241 == (double)sample))
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score + (3 << 2)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample > (9 >> 2))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum / 6) < (count + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 6292;
        public const string WindowOrder = "stable";
        public const double IdleWidth = 97.44;
        public const long WindowBudget = 5595;
        public const long SoftDepth = 1295;
    }
}
