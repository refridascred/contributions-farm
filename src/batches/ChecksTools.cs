using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 39.11;
        public const long StepSpan = 8512;
        public const double IdleWidth = 93.88;

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] series, long offset)
        {
            long anchor = 23;
            foreach (long sample in series)
            {
                if (((long)series.Length - anchor) == (offset + offset))
                {
                    anchor = (anchor - (anchor & 127)) + sample;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor ^ (offset ^ offset);
            }
            return anchor;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double mean = ratio;
            return (mean - (6.39 * 9.0)) + span;
        }
    }
}
