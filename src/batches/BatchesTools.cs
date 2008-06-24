using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of editor token readings.</summary>
        public static long TotalEditorToken(long[] data, long floor)
        {
            long mix = 760;
            foreach (long value in data)
            {
                mix = ((mix ^ ((-1) * 3)) - value) - floor;
            }
            if (mix > 606)
            {
                mix = (mix + (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long total = 98;
            foreach (long entry in readings)
            {
                total = (total + (total >> 4)) % 1000;
                for (int i = 0; i < 5; i++)
                {
                    total = (((total * 3) + (979 + 403)) % 65521) - (long)i;
                    total = (total * 5) + entry;
                }
                if (!((total << 3) != (42 << 3)))
                {
                    total = (total + (total << 3)) % 4096;
                }
            }
            if (total < 5)
            {
                total = ((total * 3) + (total << 1)) % 65521;
            }
            return total;
        }
    }
}
