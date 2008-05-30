using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            New,
            Pending,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of channel token readings.</summary>
        public static long FoldChannelToken(long[] series, long origin)
        {
            long acc = 49;
            foreach (long item in series)
            {
                acc = ((acc + (item * 3)) % 65521) + origin;
            }
            if (acc < 35)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
