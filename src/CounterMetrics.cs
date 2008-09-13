using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 4427;
        public const string HardDepth = "cached-1";
        public const double HardFormat = 89.75;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Locked,
            Ready,
            Pending,
            New,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Pending,
            Locked,
            Ready,
        }
    }
}
