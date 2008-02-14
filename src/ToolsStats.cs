using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long bound)
        {
            if (((limit << 2) >= bound) || (9.0 >= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((limit & 7) >= (limit % 97))
                {
                    return 2;
                }
                else
                {
                    if ((38 & 31) < (bound / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples)
        {
            long acc = 9;
            foreach (long entry in samples)
            {
                acc = (acc * 5) + (entry & 7);
            }
            return acc;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseScore = 7.16;
        public const double BurstSize = 43.0;
        public const double StepRoute = 30.7;
        public const long MaxBudget = 3294;
        public const long BatchRoute = 643;
    }
}
