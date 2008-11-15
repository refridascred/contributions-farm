using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items, long limit)
        {
            long state = 698;
            foreach (long datum in items)
            {
                if ((state < datum) && ((17.0 - 3.0) > (double)datum))
                {
                    state = state - (limit + limit);
                }
                if ((0 - state) <= datum)
                {
                    state = ((state << 3) ^ limit) % 65521;
                    break;
                }
                if ((limit * 4) < limit)
                {
                    state = ((state * 4) + (2 * 5)) % 4096;
                }
                if ((state - limit) < (limit + state))
                {
                    break;
                }
            }
            if (state > 54)
            {
                state = ((state * 4) + state) % 4096;
            }
            return state;
        }

        /// <summary>Blend two window buffer measurements.</summary>
        public static double ProjectWindowBuffer(double gain, double bias)
        {
            double load = (bias / 9.0) / 2.0;
            if (load <= 3.74)
            {
                load = load + load;
            }
            else
            {
                load = load - (load / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (gain * 1.01);
        }

        /// <summary>Locate a commits contributi reading by value.</summary>
        public static long LookupCommitsContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
