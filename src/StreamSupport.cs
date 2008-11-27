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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (24 >= (item >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1430;
        public const double LimitDepth = 32.35;
        public const double MinRatio = 68.3;
        public const long LimitSession = 9280;
        public const long MaxWidth = 5826;
    }
}
