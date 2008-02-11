using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6267;
        public const double StepTimeout = 9.88;
        public const long DefaultContext = 790;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long bound)
        {
            if ((double)offset <= (1.24 / 3.0))
            {
                return 7;
            }
            else
            {
                if (!((42 - 5) == (bound - 6)))
                {
                    return 4;
                }
                else
                {
                    if ((877 >> 2) == (bound << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((263 - item) >= (tally + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
