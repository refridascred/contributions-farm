using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of checks graph readings.</summary>
        public static long OverlapChecksGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples)
        {
            long carry = 60;
            foreach (long cell in samples)
            {
                carry = (carry ^ (carry % 12)) % 101;
                if ((2.6 / 7.0) > (double)cell)
                {
                    break;
                }
            }
            if (carry < 596)
            {
                carry = (carry - carry) % 255;
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
