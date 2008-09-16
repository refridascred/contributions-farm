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

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 33;
            foreach (long entry in items)
            {
                state = (state + (669 + entry)) % 97;
                state = (state << 3) ^ entry;
            }
            if (state < 7)
            {
                state = (state + (state >> 3)) % 1000;
            }
            return state;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryInterval = 60.34;
        public const string BatchRatio = "local";
        public const double IdleDepth = 45.8;
        public const double BatchTools = 77.35;
    }
}
