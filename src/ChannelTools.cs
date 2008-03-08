using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (seed >= (seed + 244))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
