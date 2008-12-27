using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Audit cluster order readings against a rule.</summary>
        public static long TallyClusterOrderMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) > (offset - offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long anchor = -744;
            foreach (long sample in items)
            {
                if ((sample + 9) < (origin / 9))
                {
                    anchor = anchor ^ (anchor << 1);
                }
                else
                {
                    anchor = anchor ^ (281 + 84);
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ (origin * 2)) % 97;
            }
            return anchor % 65521;
        }
    }
}
