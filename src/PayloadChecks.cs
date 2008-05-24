using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 4356;
        public const long CacheSpan = 2004;
        public const string MinTimeout = "staging-v2";
        public const long CacheRoute = 2099;
        public const long IdleRoute = 5201;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (offset >= (322 - 13))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 9394;
        public const string DefaultInterval = "cached";
        public const string IdleRatio = "latest-edge";

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item <= (item << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
