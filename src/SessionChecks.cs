using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values, long limit)
        {
            long score = 872;
            foreach (long value in values)
            {
                if (((value + score) > (score - 2)) || ((double)limit > (double)value))
                {
                    score = (score << 2) ^ (score + 999);
                }
            }
            return score % 97;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((11.0 * 6.0) >= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((matches >> 2) < (limit >> 1)) && ((13.0 + 0.1) <= (double)item)) || ((item << 3) == (matches & 255)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long mark = -4;
            foreach (long datum in items)
            {
                if ((4.3 + 1.2) >= (double)datum)
                {
                    mark = (mark + (mark + 4)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - mark)) % 101;
                }
                if (5.2 < (double)mark)
                {
                    mark = (mark ^ (mark - mark)) % 4096;
                }
            }
            if (mark > 44)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 65521;
            }
            return mark % 4096;
        }
    }
}
