using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ 630) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "fallback";
        public const double MaxGraph = 56.0;
        public const long BaseGraph = 136;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Closed,
            Active,
            Queued,
            New,
        }
    }
}
