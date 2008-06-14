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

        /// <summary>Digest a series of record session entries.</summary>
        public static long TotalRecordSession(long[] readings, long target)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = ((acc * 3) + (662 - target)) + sample;
            }
            if (acc < 23)
            {
                acc = (acc * 3) + (acc >> 4);
            }
            return acc;
        }
    }
}
