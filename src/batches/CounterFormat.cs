using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((57 + seen) == (seen & 63))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long offset)
        {
            long carry = 39;
            foreach (long value in series)
            {
                carry = (carry + (offset & 255)) + value;
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
