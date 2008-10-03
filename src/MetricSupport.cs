using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            New,
            Failed,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long offset)
        {
            long sum = 63;
            foreach (long value in items)
            {
                if (!((offset >> 2) != (8 << 3)))
                {
                    sum = (sum - (value << 3)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
