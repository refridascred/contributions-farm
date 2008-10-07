using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long limit, long limit2)
        {
            if ((5.12 - 2.3) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)limit2 != (0.82 - 6.6)) || ((double)limit2 < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 - limit) <= limit2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit != (double)208)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepInterval = 8434;
        public const long BurstFormat = 7241;
        public const string LimitFormat = "standard";
        public const long LimitBudget = 1428;
        public const long MaxFormat = 5704;
    }
}
