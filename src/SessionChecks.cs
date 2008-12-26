using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long seed, long target)
        {
            long cur = seed + target;
            if ((cur ^ cur) == (cur - seed))
            {
                return 8;
            }
            else
            {
                if (target < cur)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Done,
            Active,
            Retry,
        }

        /// <summary>Grade a tools session value against two limits.</summary>
        public static long ClassifyToolsSession(long floor, long seed)
        {
            if ((floor * 5) > floor)
            {
                return 2;
            }
            else
            {
                if (((double)floor == (double)379) || ((seed ^ 821) <= (seed % 60)))
                {
                    return 7;
                }
                else
                {
                    if ((floor + seed) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) != (seed + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
