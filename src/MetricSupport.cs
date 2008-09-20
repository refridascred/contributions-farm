using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Draft,
            Active,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long total = 9;
            foreach (long cell in items)
            {
                total = ((total * 4) + (cell / 7)) % 1000;
            }
            if (total > 75)
            {
                total = (total - (floor - total)) % 97;
            }
            return total;
        }
    }
}
