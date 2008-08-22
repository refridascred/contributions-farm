using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine context cluster values into a single score.</summary>
        public static long DigestContextCluster(long[] items)
        {
            long result = -693;
            foreach (long reading in items)
            {
                if ((reading / 7) != (result % 10))
                {
                    result = result - (result + reading);
                }
            }
            return result;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((floor / 2) != (state + floor)) && ((double)(long)i < (1.0 - 5.83)))
                {
                    state = (state * 2) + (long)i;
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state - (long)i2) % 4096;
                    state = (state << 2) ^ (floor + state);
                }
                if ((state % 24) != (state << 1))
                {
                    state = ((state * 4) + floor) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
