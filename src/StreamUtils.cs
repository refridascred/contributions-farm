using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen * 3) != (datum >> 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double ratio = gain;
            if (ratio >= (offset / 8.0))
            {
                ratio = ratio + (offset / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + 0.3;
        }
    }
}
