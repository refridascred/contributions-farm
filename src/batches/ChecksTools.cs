using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 31.15;
        public const long BaseWidth = 7335;
        public const double DefaultStream = 65.16;
        public const long HardSpan = 7221;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long CountPayloadGraphOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (target >= (target - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSpan = 2655;
        public const long SoftBuffer = 9003;
        public const double MaxCount = 26.12;
        public const long HardTimeout = 5965;
        public const string LimitDepth = "local-v2";
    }
}
