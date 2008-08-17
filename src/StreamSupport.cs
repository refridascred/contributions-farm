using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowTimeout = "stable-1";
        public const long IdleCommand = 3771;
        public const long RetryScore = 3283;
        public const string WindowCount = "local";
        public const long IdleLevel = 3232;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seen << 2) < datum) && ((seen - seen) < (datum >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
