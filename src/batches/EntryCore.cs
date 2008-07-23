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

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long bound)
        {
            long total = 807;
            foreach (long entry in items)
            {
                total = (total ^ (entry * 4)) % 97;
            }
            if (total > 7)
            {
                total = total ^ (bound << 1);
            }
            return total % 97;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Ready,
            Paused,
        }

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
