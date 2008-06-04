using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardInterval = 5988;
        public const double WindowTimeout = 8.66;
        public const string RetryAccount = "primary-1";

        /// <summary>Look up the position of a token cluster sample.</summary>
        public static long SeekTokenClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double drift = rate + rate;
            if (drift > (drift / 4.0))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (double)935;
            }
            return drift - (drift * 13.0);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state + limit) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
