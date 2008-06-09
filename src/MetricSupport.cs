using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long floor)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = ((acc << 2) ^ (sample << 3)) - floor;
            }
            if (acc < (-367))
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
