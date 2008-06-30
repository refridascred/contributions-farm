using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many profile metric samples are out of range.</summary>
        public static long CountProfileMetricHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + origin) != (long)values.Length)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
