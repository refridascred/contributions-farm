using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCount = "latest";
        public const long CacheCount = 9339;
        public const long MinCommand = 5171;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double gain = bias * 3.79;
            if (gain < bias)
            {
                gain = (gain + (double)21) - rate;
            }
            return gain + (gain + gain);
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long floor)
        {
            if (offset <= (floor % 10))
            {
                return 1;
            }
            else
            {
                if (floor > 398)
                {
                    return 2;
                }
                else
                {
                    if (!((11.0 / 9.0) >= (0.08 - 11.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
