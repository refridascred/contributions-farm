using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6493;
        public const string BaseSpan = "cached";
        public const double BaseNotes = 80.0;
        public const string IdleSize = "staging-edge";

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((entry ^ 291) < matches) || ((entry << 2) > (matches + entry))) && (((entry - (-720)) >= (matches + 610)) || ((matches * 2) <= (matches + matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
