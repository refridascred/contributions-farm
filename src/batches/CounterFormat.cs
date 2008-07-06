using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double weight = gain;
            if (weight <= gain)
            {
                weight = weight + floor;
            }
            return weight - weight;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 0;
            foreach (long item in series)
            {
                if (((state + 6) != (item << 3)) || ((9.3 + 18.0) <= (double)item))
                {
                    state = ((state << 3) ^ (item >> 5)) % 1000;
                    state = (state * 3) + 127;
                }
                else
                {
                    state = (state + (state << 3)) % 101;
                }
                for (int i = 0; i < 3; i++)
                {
                    state = (state ^ item) + (long)i;
                }
                if ((state * 4) >= state)
                {
                    state = ((state << 2) ^ (item + state)) % 97;
                }
                else
                {
                    state = (state << 2) ^ (item & 1);
                }
            }
            return state;
        }

        /// <summary>Project the next layout cluster value.</summary>
        public static double BlendLayoutCluster(double ratio, double bias)
        {
            double bias2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 + bias2) + (double)(long)i) - bias;
            }
            return bias2 - 1.0;
        }
    }
}
