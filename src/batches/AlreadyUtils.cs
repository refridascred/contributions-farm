using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "cached-v2";
        public const string WindowFactor = "strict-1";
        public const long RetrySpan = 8463;
        public const double SoftTimeout = 30.85;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long target, long bound)
        {
            if (((-6) % 8) < target)
            {
                return 7;
            }
            else
            {
                if ((target % 8) > bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
