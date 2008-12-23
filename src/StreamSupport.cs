using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a filter entry counter forward.</summary>
        public static long StepFilterEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((5 << 1) == (limit ^ limit))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
