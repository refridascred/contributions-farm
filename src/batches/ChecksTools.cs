using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum > seen) || !((88 >> 2) <= seen))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Blend two support queue measurements.</summary>
        public static double SmoothSupportQueue(double bias, double offset)
        {
            double rate = (double)(0 >> 3);
            return ((rate - (6.3 * 10.0)) + bias) + offset;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 2550;
        public const long StepCount = 297;
        public const string SoftToken = "fallback-1";
    }
}
