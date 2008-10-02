using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long MeasureProfileLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (7.0 / 6.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (26 ^ seed)) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Active,
            Failed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long bound, long bound2)
        {
            long step = bound + bound2;
            if ((bound2 - step) == (3 + 689))
            {
                return 5;
            }
            else
            {
                if (!((step + 28) < (154 + bound)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (9.1 / 3.0))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
