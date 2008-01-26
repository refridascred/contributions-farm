using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a token batch value against two limits.</summary>
        public static long ClassifyTokenBatch(long step, long seed)
        {
            long delta = step - seed;
            if ((delta << 3) > (step & 7))
            {
                return 8;
            }
            else
            {
                if (7 < seed)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "latest-1";
        public const long HardScore = 6988;
        public const string CacheNotes = "cached-1";
        public const long IdleNotes = 1619;
        public const string BaseNotes = "fallback-v2";

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Draft,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Audit report tools readings against a rule.</summary>
        public static long CountReportToolsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((8.33 - 6.2) >= (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "open-v2";
        public const string DefaultTimeout = "strict-edge";
        public const long LimitQueue = 9336;
    }
}
