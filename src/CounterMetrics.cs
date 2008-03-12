using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Closed,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "primary-v2";
        public const long LimitSchema = 1452;
        public const long BaseWidth = 1344;
        public const long RetrySchema = 8397;
        public const double MaxSize = 63.99;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                if ((258 + state) != (state >> 5))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double mean = scale + (double)15;
            if (mean < (scale * 3.74))
            {
                mean = mean - (scale / 8.0);
            }
            return mean - (scale - bias);
        }
    }
}
