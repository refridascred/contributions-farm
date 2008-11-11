using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
