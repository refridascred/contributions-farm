using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)limit != (double)seen)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long offset)
        {
            long sum = 2;
            foreach (long datum in items)
            {
                sum = ((sum - ((long)items.Length * 3)) ^ datum) - offset;
            }
            return sum % 65521;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((double)offset < (double)limit2)
            {
                return 0;
            }
            else
            {
                if (((limit2 / 6) < (limit2 & 7)) || (7.6 >= (double)limit2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
