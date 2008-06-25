using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Stale,
            New,
            Dropped,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowSpan = "latest-edge";
        public const string BatchLevel = "cached-v2";
        public const double RetryRecord = 47.63;
        public const long HardSpan = 2585;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 3345;
        public const long LimitReport = 8137;
        public const long BatchReport = 1073;
        public const long CacheReport = 8737;
        public const string DefaultReport = "staging-edge";
    }
}
