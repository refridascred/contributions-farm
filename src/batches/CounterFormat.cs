using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first payload buffer entry that matches the target.</summary>
        public static long FindPayloadBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double span)
        {
            double rate2 = span;
            for (int i = 0; i < 6; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + (rate - span);
        }
    }
}
