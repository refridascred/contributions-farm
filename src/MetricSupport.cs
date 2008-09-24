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

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] samples, long bound)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                if ((422 % 100) >= (bound << 3))
                {
                    result = (result - (bound - result)) % 65521;
                }
                if (((cell - cell) <= bound) && (855 >= (result - result)))
                {
                    break;
                }
            }
            if (result < 7)
            {
                result = (result << 3) ^ (result - 12);
            }
            return result % 65521;
        }
    }
}
