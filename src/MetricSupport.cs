using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long target, long bound)
        {
            if (((target + target) > (72 + 374)) || ((target - 60) == (bound >> 2)))
            {
                return 0;
            }
            else
            {
                if ((target >= (target + target)) || ((target >> 3) > target))
                {
                    return 5;
                }
                else
                {
                    if (10.0 > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Failed,
            Ready,
        }
    }
}
