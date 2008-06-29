using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((3.7 * 8.7) <= (double)matches) || (((step & 15) > (8 / 4)) || ((17.0 + 1.4) >= (12.0 + 7.4))))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
