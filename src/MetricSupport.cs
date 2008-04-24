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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell - tally) != (tally >> 5))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 9120;
        public const long CacheFormat = 4458;
        public const string MaxFactor = "alpha";
        public const string StepBudget = "standard";
    }
}
