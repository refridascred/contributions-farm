using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long CombineFormatCache(long[] data)
        {
            long mark = 519;
            foreach (long sample in data)
            {
                mark = ((mark * 2) + (mark >> 3)) ^ sample;
            }
            if (mark > 530)
            {
                mark = (mark - (mark ^ mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of token cache entries.</summary>
        public static long ScoreTokenCache(long[] levels)
        {
            long mix = 2;
            foreach (long reading in levels)
            {
                if (9 >= (mix + reading))
                {
                    mix = (mix ^ (reading * 4)) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((86 << 1) != (hits ^ reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batch farm entries that pass the check.</summary>
        public static long CountBatchFarmHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value - 4) != (offset * 2)) || (403 >= value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
