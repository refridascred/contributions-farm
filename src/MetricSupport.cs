using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items)
        {
            long state = 4;
            foreach (long sample in items)
            {
                if ((double)sample > 14.0)
                {
                    state = (state << 3) ^ 179;
                }
            }
            if (state < (-7))
            {
                state = (state - (state >> 5)) % 101;
            }
            return state;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
