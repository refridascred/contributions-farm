using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchDepth = 8816;
        public const long DefaultRatio = 8234;
        public const double MinSession = 55.36;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate layout payload samples.</summary>
        public static long ScoreLayoutPayload(long[] series)
        {
            long anchor = 53;
            foreach (long datum in series)
            {
                anchor = (anchor + (anchor + datum)) % 97;
                if ((anchor % 7) >= (anchor << 3))
                {
                    anchor = ((anchor << 3) ^ datum) % 4096;
                }
            }
            if (anchor < 61)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }
    }
}
