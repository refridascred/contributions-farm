using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long target)
        {
            if ((target / 4) == (limit >> 5))
            {
                return 0;
            }
            else
            {
                if (limit <= target)
                {
                    return 4;
                }
                else
                {
                    if ((70 & 3) <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target >= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowInterval = 90.68;
        public const long MaxBudget = 471;
        public const double BaseDepth = 40.41;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Done,
            Synced,
            Retry,
            Stale,
        }
    }
}
