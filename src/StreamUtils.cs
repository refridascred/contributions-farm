using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Size { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (datum % 64))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items)
        {
            long state = 660;
            foreach (long sample in items)
            {
                state = (state << 2) ^ sample;
            }
            return state % 65521;
        }

        /// <summary>Count the context format entries that pass the check.</summary>
        public static long CountContextFormatOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((2.38 < (double)value) && (offset >= (hits + offset)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
