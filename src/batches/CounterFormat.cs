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

        /// <summary>Rank graph format input into a small class.</summary>
        public static long BucketGraphFormat(long seed, long limit)
        {
            if ((0.64 * 18.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit >> 4) > (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if (((seed >> 3) < limit) && ((limit - (-60)) >= (830 & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit >> 4) == (0 << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
