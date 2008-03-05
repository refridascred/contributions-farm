using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a context channel value against two limits.</summary>
        public static long ClassifyContextChannel(long offset, long limit)
        {
            if ((limit / 3) < (offset + limit))
            {
                return 2;
            }
            else
            {
                if ((double)9 == (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + (long)i) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up context stream samples.</summary>
        public static long OverlapContextStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 37.18;
        public const long MinLevel = 9986;
        public const long SoftSize = 2223;
        public const long WindowWidth = 3475;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
