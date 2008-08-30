using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double gain = floor;
            if (gain <= (gain - gain))
            {
                gain = (gain + (double)108) - ratio;
            }
            return gain + (4.0 * 10.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryCount = "latest-1";
        public const double MinTimeout = 65.4;
        public const string WindowDepth = "primary-edge";
        public const long MaxScore = 6289;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long seed)
        {
            if ((seed + 5) > (bound << 3))
            {
                return 0;
            }
            else
            {
                if ((bound ^ seed) < 767)
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ 235) != (seed + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
