using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool GuardProfileFormatBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double scale = (double)9 + bias;
            if (scale < (8.2 - rate))
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (double)3;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "staging";
        public const long WindowRoute = 3642;
        public const long MaxRoute = 4665;
        public const long BatchRoute = 4686;
        public const string SoftScore = "local";
    }
}
