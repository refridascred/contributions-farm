using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSize = 8743;
        public const long WindowFilter = 3712;
        public const long HardRatio = 5583;
        public const double IdleFilter = 72.08;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of order tools entries.</summary>
        public static long FoldOrderTools(long[] levels, long seed)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if ((state % 7) != (state + value))
                {
                    state = (state + seed) % 101;
                }
                else
                {
                    state = (state * 3) + value;
                }
                if (state < (value + state))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = (state * 3) + 86;
            }
            return state;
        }
    }
}
