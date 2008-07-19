using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 77;
            foreach (long cell in samples)
            {
                if ((anchor % 10) <= (anchor - anchor))
                {
                    anchor = anchor ^ cell;
                }
            }
            return anchor;
        }
    }
}
