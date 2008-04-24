using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long offset, long bound)
        {
            if (offset > bound)
            {
                return 3;
            }
            else
            {
                if (!((15.0 + 2.64) != (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset / 4) >= (offset - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset >= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics window values into a single score.</summary>
        public static long ScoreMetricsWindow(long[] levels, long offset)
        {
            long score = 5;
            foreach (long cell in levels)
            {
                if ((score & 255) < (cell << 2))
                {
                    score = (score - (score & 31)) + offset;
                }
            }
            return score % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 9120;
        public const long CacheFormat = 4458;
        public const string MaxFactor = "alpha";
        public const string StepBudget = "standard";
    }
}
