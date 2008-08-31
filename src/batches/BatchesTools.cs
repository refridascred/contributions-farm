using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((step % 10) != (cell - cell)) || ((double)cell >= 16.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long TallyMetricsCache(long[] readings)
        {
            long mix = 4;
            foreach (long item in readings)
            {
                if (!((0 << 3) > item))
                {
                    mix = ((mix << 2) ^ item) % 1000;
                }
            }
            if (mix > 4)
            {
                mix = mix ^ (2 + (long)readings.Length);
            }
            return mix % 4096;
        }
    }
}
