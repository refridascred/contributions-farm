using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((count << 3) > count))
                {
                    count = ((count + 2) ^ entry) + step;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 64.16;
        public const double WindowLevel = 73.85;
        public const long StepBatch = 866;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] items)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = ((acc * 2) + 387) % 255;
                acc = acc ^ ((-1) << 1);
                acc = ((acc * 5) + (reading + reading)) % 4096;
            }
            if (acc > (-9))
            {
                acc = acc + acc;
            }
            return acc % 65521;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((delta + 278) >= (delta + delta))
            {
                return 4;
            }
            else
            {
                if ((9.0 - 16.0) != (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
