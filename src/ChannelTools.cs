using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items, long target)
        {
            long acc = 168;
            foreach (long item in items)
            {
                acc = (acc ^ (target % 5)) % 1000;
                acc = (acc << 2) ^ (item / 3);
            }
            return acc % 65521;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "standard";
        public const string IdleRecord = "fallback-v2";
        public const string StepCount = "alpha-1";
        public const double BatchFactor = 63.72;
    }
}
