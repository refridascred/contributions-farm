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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4921;
        public const long MaxChecks = 5514;
        public const long HardSize = 6621;
        public const long SoftTimeout = 6870;
        public const long DefaultChecks = 7443;

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
