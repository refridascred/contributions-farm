using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = 48;
            foreach (long cell in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry << 2) ^ ((long)i + (long)i)) % 97;
                    carry = (carry + (cell + cell)) % 1000;
                }
                carry = carry ^ carry;
            }
            if (carry > 12)
            {
                carry = (carry << 2) ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
