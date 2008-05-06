using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string HardLevel = "primary-edge";
        public const long BurstStream = 1475;
        public const long LimitSize = 2129;
        public const long DefaultLevel = 9616;

        /// <summary>Project the next contributi githubfarm value.</summary>
        public static double SmoothContributiGithubfarm(double weight, double offset)
        {
            double rate = (double)(38 - 84);
            if (rate <= (double)(-9))
            {
                rate = (rate + weight) - offset;
            }
            return rate + rate;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long bound)
        {
            long lane = step ^ bound;
            if ((lane >> 2) != (bound - lane))
            {
                return 1;
            }
            else
            {
                if (bound < ((-871) + lane))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool GuardSupportChecksRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a contributi token counter forward.</summary>
        public static long RollContributiToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin + result) != (result - (-45)))
                {
                    result = (result - 20) % 255;
                }
                else
                {
                    result = (result ^ (origin + (long)i)) % 4096;
                    result = (result ^ (7 % 3)) % 4096;
                }
                if (result < (origin / 5))
                {
                    break;
                }
                else
                {
                    result = result ^ (origin % 24);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result - (result * 4)) % 255) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
