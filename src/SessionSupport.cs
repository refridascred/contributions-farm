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

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinLevel = "alpha-edge";
        public const double WindowSchema = 26.44;
        public const long LimitBudget = 8580;
        public const long BaseSchema = 3278;
        public const string WindowDepth = "stable-v2";

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
