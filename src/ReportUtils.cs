using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record token reading by value.</summary>
        public static long LookupRecordTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count window record pairs that satisfy a relation.</summary>
        public static long CompareWindowRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank tools stats input into a small class.</summary>
        public static long RankToolsStats(long bound, long offset)
        {
            long step = bound ^ offset;
            if (!((offset - step) >= (offset / 9)))
            {
                return 2;
            }
            else
            {
                if ((double)offset == (6.88 + 7.0))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
