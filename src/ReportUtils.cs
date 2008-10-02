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

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 3672;
        public const long SoftSchema = 9753;
        public const long CacheSchema = 2010;

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
