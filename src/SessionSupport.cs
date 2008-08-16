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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long floor)
        {
            long prev = step - floor;
            if ((5.4 / 4.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((50 % 10) > prev)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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
