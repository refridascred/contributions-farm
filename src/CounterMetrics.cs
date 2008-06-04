using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Idle,
            New,
            Closed,
        }

        /// <summary>Check that every filter cache entry stays within the limit.</summary>
        public static bool VerifyFilterCacheLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
