using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample << 3) >= (sample >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout commits entry stays within the limit.</summary>
        public static bool GuardLayoutCommitsRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
