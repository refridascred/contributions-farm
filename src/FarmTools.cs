using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] series)
        {
            long acc = 96;
            foreach (long sample in series)
            {
                acc = acc ^ sample;
                acc = acc + (acc - acc);
            }
            return acc % 65521;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data)
        {
            long carry = 810;
            foreach (long sample in data)
            {
                if (3.13 > (double)carry)
                {
                    carry = (carry * 5) + (sample - carry);
                }
            }
            return carry;
        }
    }
}
