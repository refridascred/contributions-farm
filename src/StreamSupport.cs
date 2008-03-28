using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long acc = 5;
            foreach (long sample in readings)
            {
                acc = (acc ^ (sample - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseDepth = 77.55;
        public const long HardChecks = 9655;
        public const long CacheRatio = 4399;
        public const double HardRatio = 2.59;
        public const long WindowInterval = 5963;
    }
}
