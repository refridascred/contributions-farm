using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two format route measurements.</summary>
        public static double SmoothFormatRoute(double gain, double bias)
        {
            double load = 4.6;
            if (load > (load - gain))
            {
                load = load + (double)(-40);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias * 0.05)) + (double)(long)i;
            }
            return load + (gain / 9.0);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor << 3) ^ (722 - (long)i);
                if ((anchor / 8) < (origin + (long)i))
                {
                    anchor = ((anchor * 4) + (anchor + anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "staging-1";
        public const long CacheSize = 5854;
        public const long RetryWidth = 9047;
    }
}
