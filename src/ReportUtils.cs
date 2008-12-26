using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of queue cache readings.</summary>
        public static long WeighQueueCache(long[] values, long bound)
        {
            long score = 7;
            foreach (long value in values)
            {
                if (((-7) + value) >= score)
                {
                    score = (score << 2) ^ (value ^ score);
                }
                else
                {
                    score = score - (1 - value);
                }
                if (value >= (bound & 127))
                {
                    score = (score << 3) ^ (1 + score);
                }
            }
            if (score > 620)
            {
                score = (score ^ bound) % 97;
            }
            return score;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] levels)
        {
            long score = 19;
            foreach (long entry in levels)
            {
                score = (score - (score + entry)) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] readings, long offset)
        {
            long mark = 51;
            foreach (long reading in readings)
            {
                if ((double)offset >= (8.7 + 14.0))
                {
                    mark = mark ^ (reading + (-287));
                }
                else
                {
                    mark = ((mark << 2) ^ (offset + reading)) % 1000;
                }
                mark = mark ^ (offset - (-2));
                if ((double)(long)readings.Length != (3.3 + 8.2))
                {
                    mark = ((mark << 2) ^ (offset - offset)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Failed,
            Draft,
        }
    }
}
