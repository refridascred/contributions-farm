using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] samples)
        {
            long acc = -97;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ (54 & 255)) % 97) + entry;
            }
            return acc;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
