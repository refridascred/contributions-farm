using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "standard-edge";
        public const string BatchToken = "latest-edge";
        public const long RetryToken = 3463;
        public const double CacheRatio = 11.04;

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double offset)
        {
            double gain = (bias - offset) - bias;
            if (gain > (double)106)
            {
                gain = gain - (double)34;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (double)311;
        }

        /// <summary>Match up support buffer samples.</summary>
        public static long OverlapSupportBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleRatio = 84.51;
        public const long RetryGraph = 6473;
        public const long MinGraph = 4526;
        public const double WindowLevel = 83.77;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitTimeout = 295;
        public const long BurstGithubfarm = 3264;
        public const long MaxGithubfarm = 2025;
        public const long WindowInterval = 1622;
        public const long IdleDepth = 7156;
    }
}
