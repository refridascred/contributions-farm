using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a layout profile reading by value.</summary>
        public static long FindLayoutProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double floor)
        {
            double load = floor;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load + ratio)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 21.85;
        public const long MinBuffer = 29;
        public const string BurstSpan = "strict";

        /// <summary>Match up buffer channel samples.</summary>
        public static long PairBufferChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long floor)
        {
            long carry = 183;
            foreach (long cell in readings)
            {
                carry = ((carry - cell) % 1000) + floor;
            }
            if (carry > 322)
            {
                carry = ((carry * 4) + (706 >> 5)) % 1000;
            }
            return carry % 65521;
        }
    }
}
