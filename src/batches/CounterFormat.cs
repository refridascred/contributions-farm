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

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitBudget = 7902;
        public const string BaseRatio = "open";
        public const long IdleTimeout = 460;
        public const double BatchSupport = 46.22;
    }
}
