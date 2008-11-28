using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data)
        {
            long state = 62;
            foreach (long item in data)
            {
                if ((state - 95) == (78 + 92))
                {
                    state = (state + (item + item)) % 1000;
                    continue;
                }
                state = state - (state + 7);
            }
            return state;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double bias = scale - (double)31;
            if (bias < floor)
            {
                bias = bias - (floor - floor);
            }
            else
            {
                bias = bias - (3.31 + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (scale - bias)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
