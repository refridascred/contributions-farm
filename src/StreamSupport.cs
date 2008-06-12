using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double span)
        {
            double ratio = (double)26 * 0.39;
            return ((ratio - ratio) + scale) + span;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (394 <= (seen + 94))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
