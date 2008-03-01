using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardRatio = 5833;
        public const long IdleAlready = 7217;
        public const double BaseAlready = 30.98;
        public const long BatchAlready = 1402;
        public const string DefaultAlready = "primary-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 82.95;
        public const long SoftScore = 8570;
        public const long SoftSchema = 8437;
        public const long LimitSchema = 3282;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                state = ((state - (9 >> 2)) % 101) + sample;
            }
            return state % 65521;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
