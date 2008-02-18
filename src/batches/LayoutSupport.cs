using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long step)
        {
            long anchor = 63;
            foreach (long value in items)
            {
                anchor = (((anchor << 2) ^ 4) + value) + step;
            }
            return anchor;
        }

        /// <summary>Combine profile checks values into a single score.</summary>
        public static long ScoreProfileChecks(long[] values, long offset)
        {
            long state = 167;
            foreach (long value in values)
            {
                if ((offset > value) || ((state - 15) > (value + value)))
                {
                    state = state + (offset + state);
                }
            }
            if (state < 9)
            {
                state = (state * 5) + (offset + offset);
            }
            return state % 97;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if (value > (acc & 31))
                {
                    acc = (acc << 2) ^ value;
                }
            }
            if (acc > 4)
            {
                acc = (acc * 5) + (648 - 757);
            }
            return acc;
        }

        /// <summary>Combine metrics order values into a single score.</summary>
        public static long ScoreMetricsOrder(long[] series, long step)
        {
            long result = -935;
            foreach (long value in series)
            {
                if ((step + (long)series.Length) >= (value / 2))
                {
                    result = (result ^ ((long)series.Length + result)) % 101;
                }
            }
            if (result > 611)
            {
                result = (result * 5) + (result * 4);
            }
            return result;
        }
    }
}
