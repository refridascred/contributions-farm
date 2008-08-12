using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count command stream pairs that satisfy a relation.</summary>
        public static long MatchCommandStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit editor session readings against a rule.</summary>
        public static long CountEditorSessionHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((8 / 6) != (hits - hits)) || ((cell >= (cell - cell)) && ((double)hits == (double)cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
