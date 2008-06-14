using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ (offset - anchor)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long TallySupportQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) >= (item >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
