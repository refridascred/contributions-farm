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

        /// <summary>Accumulate order cluster samples.</summary>
        public static long ScoreOrderCluster(long[] levels, long origin)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                mix = (mix + (mix - value)) + origin;
            }
            return mix;
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
