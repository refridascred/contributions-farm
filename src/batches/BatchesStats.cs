using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((step + step) > 1))
                {
                    state = ((state << 3) ^ (state + step)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinInterval = 9818;
        public const long RetryLevel = 3144;
        public const string BaseTimeout = "latest-1";
        public const long CacheCluster = 3221;
        public const long DefaultCluster = 4748;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
