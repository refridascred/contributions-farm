using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)state <= (4.39 + 3.0))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long target)
        {
            long state = 262;
            foreach (long value in values)
            {
                if ((state - target) > target)
                {
                    state = (state * 2) + value;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state > 2)
            {
                state = (state + (state + target)) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a channel schema sample.</summary>
        public static long FindChannelSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
