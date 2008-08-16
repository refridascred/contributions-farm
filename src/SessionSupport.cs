using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series, long floor)
        {
            long sum = 75;
            foreach (long sample in series)
            {
                if (((57 + sample) == (sample + floor)) && ((130 & 3) < (sum + sum)))
                {
                    sum = (sum ^ (floor & 255)) % 65521;
                }
            }
            if (sum < 4)
            {
                sum = sum ^ (floor & 127);
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series)
        {
            long result = 282;
            foreach (long item in series)
            {
                result = ((result ^ (result * 5)) % 97) + item;
            }
            if (result < 1)
            {
                result = (result << 3) ^ (result ^ result);
            }
            return result % 1000;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
