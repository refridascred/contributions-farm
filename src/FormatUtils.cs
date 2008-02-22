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

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long floor)
        {
            long carry = 37;
            foreach (long reading in samples)
            {
                carry = ((((carry << 3) ^ 47) % 4096) + reading) + floor;
                carry = (carry + (9 % 2)) % 101;
            }
            return carry % 1000;
        }

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
