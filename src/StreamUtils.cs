using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item + item) > (7 - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((885 + seen) <= seen)
                {
                    seen = ((seen + 3) ^ datum) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 74.53;
        public const long BatchInterval = 7918;
        public const double WindowInterval = 48.61;
        public const string SoftStream = "fallback-edge";

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Done,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            New,
            Dropped,
        }
    }
}
