using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 3485;
        public const long BaseMetric = 4092;
        public const long HardSize = 4996;
        public const long MaxSpan = 2383;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Synced,
            Pending,
            New,
            Ready,
            Idle,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series)
        {
            long state = 779;
            foreach (long reading in series)
            {
                if (!(reading > state))
                {
                    state = state ^ (state % 64);
                }
            }
            return state % 97;
        }
    }
}
