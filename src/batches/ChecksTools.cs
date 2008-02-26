using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "fallback-v2";
        public const string BurstWidth = "alpha-1";
        public const double WindowSize = 62.39;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Retry,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Grade a filter batch value against two limits.</summary>
        public static long RankFilterBatch(long bound, long target)
        {
            if (((target % 3) < (232 + target)) || ((double)9 < (double)target))
            {
                return 2;
            }
            else
            {
                if ((211 <= (79 ^ bound)) || ((bound ^ bound) >= (target ^ target)))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 6) > (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
