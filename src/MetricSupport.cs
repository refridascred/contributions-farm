using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] readings)
        {
            long acc = 551;
            foreach (long item in readings)
            {
                acc = (acc * 3) + (acc + item);
                acc = ((acc << 2) ^ (acc + item)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Done,
            Ready,
        }
    }
}
