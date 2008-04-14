using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample < (sample + matches)) || ((8.3 * 16.0) >= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepRatio = "cached-1";
        public const long BurstEditor = 9397;
        public const long CacheEditor = 447;
        public const string DefaultInterval = "standard-v2";
    }
}
