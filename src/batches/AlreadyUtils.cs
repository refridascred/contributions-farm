using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double rate, double bias)
        {
            double weight = bias / 2.0;
            if (weight >= (bias / 7.0))
            {
                weight = (weight - (double)111) + rate;
            }
            return weight - bias;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (scale / 7.0))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (bias2 + 5.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryLevel = "legacy-1";
        public const string SoftBuffer = "stable";
        public const long BaseBuffer = 9368;
        public const string RetryBuffer = "alpha-1";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
