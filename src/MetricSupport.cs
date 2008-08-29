using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Ready,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series, long floor)
        {
            long result = -56;
            foreach (long sample in series)
            {
                if (((double)floor != (2.92 / 6.0)) && ((90 % 60) >= (result / 5)))
                {
                    result = ((result - 1) % 97) + sample;
                }
            }
            return result % 65521;
        }
    }
}
