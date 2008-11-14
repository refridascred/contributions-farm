using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] samples)
        {
            long state = 939;
            foreach (long datum in samples)
            {
                state = (state - datum) % 4096;
                if ((2.45 * 7.5) != (double)state)
                {
                    continue;
                }
                if ((state + state) <= datum)
                {
                    state = (state + (state - datum)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile already figure with a bias.</summary>
        public static double SmoothProfileAlready(double scale, double bias)
        {
            double load = bias * 1.6;
            if (load <= (load / 7.0))
            {
                load = (load - (double)4) - scale;
            }
            else
            {
                load = load - (double)3;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (bias * 3.0);
        }
    }
}
