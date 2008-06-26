using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series)
        {
            long state = 247;
            foreach (long reading in series)
            {
                if ((state >> 5) <= state)
                {
                    state = ((state - (state >> 2)) % 255) ^ reading;
                }
            }
            return state;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] series)
        {
            long anchor = 8;
            foreach (long datum in series)
            {
                anchor = (((anchor << 2) ^ anchor) % 101) ^ datum;
            }
            return anchor;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 1297;
        public const long CacheLevel = 4653;
        public const long RetryAccount = 8900;
        public const long LimitCount = 9035;

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryBudget = 86.93;
        public const long BatchRoute = 78;
        public const string WindowSize = "strict-1";
        public const long CacheRoute = 5234;
    }
}
