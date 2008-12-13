using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate report stats samples.</summary>
        public static long TotalReportStats(long[] samples)
        {
            long carry = 440;
            foreach (long entry in samples)
            {
                carry = ((carry + (carry - carry)) % 101) ^ entry;
            }
            if (carry < 5)
            {
                carry = (carry ^ (1 & 1)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many schema already samples are out of range.</summary>
        public static long MeasureSchemaAlreadyGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((8 + seen) < (origin << 1)))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
