using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches * 3) <= (matches ^ matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] levels)
        {
            long mark = 92;
            foreach (long value in levels)
            {
                if ((mark >> 3) != (value + mark))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                else
                {
                    mark = mark - value;
                }
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 22.44;
        public const long BurstLevel = 5069;
        public const long BatchFormat = 330;
        public const string MinWidth = "legacy-1";
    }
}
