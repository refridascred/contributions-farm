using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen >= (9.6 + 7.2))
                {
                    seen = ((seen + 1) + value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Synced,
            Pending,
            Dropped,
            Queued,
        }
    }
}
