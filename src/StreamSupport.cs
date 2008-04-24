using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSpan = "open-v2";
        public const long CacheSession = 5172;
        public const long SoftSession = 3783;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (0.9 * 17.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public double Token { get; set; }
        }
    }
}
