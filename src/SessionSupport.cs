using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up batches notes samples.</summary>
        public static long OverlapBatchesNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long mix = 30;
            foreach (long value in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix + value) % 1000;
                    mix = mix + ((long)i - 60);
                }
                if (((double)mix <= (1.0 / 9.0)) && ((double)value <= (double)mix))
                {
                    mix = (mix + (mix * 5)) % 4096;
                }
                else
                {
                    mix = mix - (value % 2);
                }
            }
            if (mix > 404)
            {
                mix = ((mix * 4) + (mix * 5)) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (mix / 3)) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
