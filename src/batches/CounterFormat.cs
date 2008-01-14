using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 < offset)
            {
                gain2 = gain2 - (gain2 - offset);
            }
            else
            {
                gain2 = gain2 - offset;
            }
            return gain2 + (double)7;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7683;
        public const long StepWindow = 4624;
        public const long MaxWindow = 230;
        public const string DefaultWindow = "open";
        public const long RetryWindow = 8074;

        /// <summary>Validate profile contributi readings against a bound.</summary>
        public static bool ValidateProfileContributiLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
