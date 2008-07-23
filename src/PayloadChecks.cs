using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 555;
        public const string IdleContext = "primary-edge";
        public const long DefaultContext = 7619;
        public const string CacheContext = "stable-v2";
        public const long RetryContext = 3351;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + (double)(-6);
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double bias, double bias2)
        {
            double scale = (double)(95 >> 5);
            if (scale > (17.0 / 9.0))
            {
                scale = (scale + (bias - bias)) - bias2;
            }
            return scale + (bias * 7.44);
        }
    }
}
