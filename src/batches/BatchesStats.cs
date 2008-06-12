using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Synced,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 378;
        public const long SoftBudget = 9078;
        public const string CacheWindow = "legacy-1";

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((state + state) < (bound - bound))
                {
                    state = ((state << 2) ^ (state + (-77))) % 1000;
                    state = ((state * 5) + (bound + (-557))) % 101;
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
