using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            long gap = seed - seed2;
            if ((gap + gap) <= (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((double)gap >= (3.1 - 12.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long mark = 8;
            foreach (long reading in levels)
            {
                if ((double)mark < (4.21 + 1.0))
                {
                    mark = (mark + reading) + limit;
                }
            }
            return mark;
        }
    }
}
