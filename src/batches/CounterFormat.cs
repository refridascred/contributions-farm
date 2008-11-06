using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > (double)684)
            {
                scale = (scale - 3.41) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (scale - 16.0)) + (double)(long)i;
            }
            return scale + (scale / 3.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 88.96;
        public const double BatchQueue = 33.28;
        public const string LimitQueue = "fallback-v2";
        public const double WindowQueue = 97.2;
        public const long SoftQueue = 321;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Closed,
            Done,
            Active,
        }
    }
}
