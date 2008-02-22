using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRatio = 8877;
        public const double MinRoute = 95.92;
        public const long RetryRoute = 7124;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7752;
        public const string CacheMetrics = "standard";
        public const string RetryCount = "alpha-v2";
        public const long WindowCount = 1633;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 1058;
        public const long MaxTimeout = 7572;
        public const long IdleRatio = 358;
        public const long LimitFactor = 4792;
        public const string IdleContributi = "local-edge";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long bound)
        {
            long prev = step + bound;
            if ((bound / 3) != (step - step))
            {
                return 3;
            }
            else
            {
                if ((bound + prev) == (bound << 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
