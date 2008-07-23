using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((anchor >> 1) != (bound * 5))
                {
                    anchor = (anchor - anchor) % 97;
                }
                if ((9 & 127) == (bound + bound))
                {
                    anchor = (anchor << 3) ^ bound;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((51 / 4) >= matches)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "alpha-1";
        public const long DefaultRatio = 1799;
        public const long IdleSpan = 5355;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
