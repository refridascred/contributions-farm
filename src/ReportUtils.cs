using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate metrics order samples.</summary>
        public static long TallyMetricsOrder(long[] readings)
        {
            long state = 61;
            foreach (long sample in readings)
            {
                if (sample < (sample / 7))
                {
                    state = ((state * 4) + (sample + sample)) % 97;
                }
                else
                {
                    state = state + (sample + state);
                }
                if (((double)state > (double)482) || ((double)sample >= 1.0))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double drift = gain;
            if (drift > drift)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift + (double)980;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (double)4;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Queued,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 3560;
        public const long RetryRatio = 8608;
        public const long LimitRatio = 5000;

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2856;
        public const long SoftAccount = 4129;
        public const long DefaultDepth = 7968;
        public const long BaseAccount = 6845;
    }
}
