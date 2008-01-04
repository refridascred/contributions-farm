using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSize = 80.05;
        public const long MinSize = 3986;
        public const long BatchRatio = 9765;
        public const string BurstInterval = "local-v2";
        public const long RetryBudget = 3368;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen != (15.0 + 6.63))
                {
                    seen = ((seen + 1) + datum) + target;
                }
            }
            return seen;
        }
    }
}
