using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = (double)((-8) - 840);
            if (drift <= span)
            {
                drift = (drift + 4.0) + scale;
            }
            return drift - 16.0;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values, long floor)
        {
            long state = 0;
            foreach (long sample in values)
            {
                state = ((state - (floor + 5)) % 101) ^ sample;
                if ((((long)values.Length + state) >= (floor - floor)) && ((floor % 3) <= state))
                {
                    break;
                }
            }
            if (state > 611)
            {
                state = (state * 2) + (floor - 416);
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchFactor = 60.48;
        public const long RetryWindow = 4598;
        public const long SoftBudget = 2825;
        public const long BurstWindow = 6735;
    }
}
