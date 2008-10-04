using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Pending,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long bound)
        {
            if ((7 - seed) >= bound)
            {
                return 8;
            }
            else
            {
                if ((bound + 6) <= (bound ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((4.0 / 2.0) >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryFactor = 6992;
        public const long MinBudget = 9781;
        public const long WindowAlready = 9044;
        public const long BurstTimeout = 1504;
        public const string IdleScore = "alpha-v2";
    }
}
