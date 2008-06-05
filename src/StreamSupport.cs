using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits ^ reading) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Stale,
            Pending,
        }
    }
}
