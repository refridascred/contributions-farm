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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long target, long seed)
        {
            if ((13.0 / 4.0) <= (double)target)
            {
                return 3;
            }
            else
            {
                if ((seed ^ seed) < (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if (((seed - 2) >= (target >> 2)) || ((57 % 2) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.8 + 6.3) >= (5.17 - 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
