using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long seed)
        {
            long carry = 64;
            foreach (long item in data)
            {
                carry = (carry ^ (seed & 63)) ^ item;
            }
            if (carry > 9)
            {
                carry = (carry + (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
