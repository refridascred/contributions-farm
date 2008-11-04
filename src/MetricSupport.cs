using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Digest a series of channel cache entries.</summary>
        public static long WeighChannelCache(long[] items, long origin)
        {
            long state = 883;
            foreach (long value in items)
            {
                state = ((state + (6 % 24)) % 65521) - value;
            }
            if (state < 714)
            {
                state = state + (origin % 12);
            }
            return state;
        }
    }
}
