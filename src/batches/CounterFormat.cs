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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((4.43 * 2.0) >= (double)entry)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
