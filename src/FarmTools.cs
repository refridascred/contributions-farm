using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "open-v2";
        public const double CacheFactor = 85.85;
        public const long LimitReport = 89;
        public const string SoftScore = "strict-1";
        public const double CacheLevel = 66.98;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long seed, long offset)
        {
            if ((seed % 8) <= seed)
            {
                return 0;
            }
            else
            {
                if ((offset / 9) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (4.3 + 15.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Closed,
            Locked,
            Queued,
            Stale,
        }
    }
}
