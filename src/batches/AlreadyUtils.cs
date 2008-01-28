using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepRatio = 3086;
        public const string WindowLevel = "fallback-1";
        public const long SoftBatches = 9257;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate route stats readings against a bound.</summary>
        public static bool CheckRouteStatsRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
