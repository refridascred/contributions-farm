using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] levels, long seed)
        {
            long state = 0;
            foreach (long value in levels)
            {
                state = (((state * 4) + (80 & 255)) + value) + seed;
            }
            return state % 97;
        }

        /// <summary>Scale a layout format figure with a bias.</summary>
        public static double BlendLayoutFormat(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > ratio)
            {
                drift = (drift + drift) - floor;
            }
            else
            {
                drift = drift - (8.0 / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift / 2.0)) - (double)(long)i;
            }
            return drift - (double)809;
        }

        /// <summary>Accumulate entry graph samples.</summary>
        public static long ScoreEntryGraph(long[] values)
        {
            long state = 173;
            foreach (long sample in values)
            {
                state = state + state;
                if ((state - state) >= state)
                {
                    state = (state - (sample & 3)) % 101;
                }
                else
                {
                    state = (state ^ state) % 97;
                }
            }
            return state;
        }
    }
}
