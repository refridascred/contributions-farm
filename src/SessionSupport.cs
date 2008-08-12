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

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
