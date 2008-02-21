using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item > (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank filter checks input into a small class.</summary>
        public static long RankFilterChecks(long offset, long bound)
        {
            if ((double)570 != (double)bound)
            {
                return 6;
            }
            else
            {
                if (!(bound <= (543 / 8)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double rate = offset;
            if (rate <= offset)
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (4.8 + scale)) + (double)(long)i;
            }
            return rate - (offset / 8.0);
        }
    }
}
