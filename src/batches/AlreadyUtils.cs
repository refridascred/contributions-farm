using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSize = 7352;
        public const long MinSupport = 8916;
        public const string MinSize = "alpha-v2";
        public const long BatchSupport = 7214;

        /// <summary>Measure how many session cluster samples are out of range.</summary>
        public static long TallySessionClusterGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits - entry) >= (hits * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches queue samples are out of range.</summary>
        public static long AuditBatchesQueueGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((item & 127) != (item - item)) || ((bound + matches) >= (matches / 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if ((576 << 2) >= (reading + reading))
                {
                    total = (total << 2) ^ (reading + 3);
                }
                else
                {
                    total = (total + reading) % 65521;
                }
            }
            return total;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((((1.8 / 8.0) != (double)(long)series.Length) && ((count - count) > 367)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
