using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long seed, long floor)
        {
            if (seed <= (seed ^ floor))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) != (floor - floor))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Failed,
            Synced,
            Done,
            New,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Retry,
        }
    }
}
