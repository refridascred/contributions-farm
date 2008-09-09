using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long target, long offset)
        {
            if ((target + 24) <= target)
            {
                return 4;
            }
            else
            {
                if (12.0 <= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset > (double)target) && ((offset * 5) >= target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target / 6) < (target + offset))
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
    }
}
