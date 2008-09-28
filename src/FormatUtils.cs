using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Draft,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCount = 37.9;
        public const double MaxCluster = 51.79;
        public const long SoftDepth = 7978;

        /// <summary>Define token limits and defaults.</summary>
        public const string HardCount = "strict-1";
        public const double LimitToken = 39.92;
        public const double MaxToken = 74.15;
        public const double StepToken = 4.63;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)matches >= (3.5 + 20.0)) && ((double)reading > 0.05))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
