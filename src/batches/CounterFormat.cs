using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings)
        {
            long state = 748;
            foreach (long entry in readings)
            {
                if ((-66) > state)
                {
                    state = (((state << 2) ^ (state % 7)) % 101) + entry;
                }
                else
                {
                    state = ((state * 5) + (state - 18)) % 4096;
                }
            }
            if (state > 5)
            {
                state = (state ^ state) % 97;
            }
            return state % 97;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
