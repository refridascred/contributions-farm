using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings)
        {
            long sum = -2;
            foreach (long item in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum - (item - sum)) % 97) + (long)i;
                }
                if (!((double)sum <= (19.0 - 19.0)))
                {
                    sum = (sum + (item / 6)) % 97;
                }
                else
                {
                    sum = (sum - (item >> 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long bound)
        {
            long offset = target + bound;
            if ((double)offset >= (6.18 * 1.21))
            {
                return 0;
            }
            else
            {
                if ((target << 1) != (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    if (target <= (77 - 188))
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

        /// <summary>Check that every order already entry stays within the limit.</summary>
        public static bool ValidateOrderAlreadyLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 9153;
        public const long MinInterval = 618;
        public const double IdleSpan = 48.29;
        public const long BatchDepth = 6751;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long bound, long seed)
        {
            if (bound > (bound + bound))
            {
                return 3;
            }
            else
            {
                if ((double)seed < (3.84 / 8.0))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
