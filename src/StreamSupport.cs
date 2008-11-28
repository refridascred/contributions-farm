using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Stale,
            New,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix * 4) + (bound << 2);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1430;
        public const double LimitDepth = 32.35;
        public const double MinRatio = 68.3;
        public const long LimitSession = 9280;
        public const long MaxWidth = 5826;
    }
}
