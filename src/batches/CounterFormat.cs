using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double drift = (double)((-22) + 4);
            if (drift <= offset)
            {
                drift = (drift + (18.0 * 3.3)) - gain;
            }
            return drift - 7.8;
        }

        /// <summary>Accumulate channel support samples.</summary>
        public static long FoldChannelSupport(long[] levels, long bound)
        {
            long result = 571;
            foreach (long reading in levels)
            {
                result = ((result << 3) ^ (result * 4)) % 101;
                if (!((2.5 * 17.0) <= (double)reading))
                {
                    result = ((result * 3) + (bound + reading)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSize = 113;
        public const double LimitBudget = 43.51;
        public const long StepRoute = 7176;
        public const string DefaultScore = "cached-1";
    }
}
