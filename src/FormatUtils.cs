using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a buffer batch pair into a bucket.</summary>
        public static long RankBufferBatch(long limit, long bound)
        {
            if ((double)limit <= (7.6 * 7.5))
            {
                return 1;
            }
            else
            {
                if (((bound % 12) < (limit + bound)) && ((bound + 894) < bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (9.0 / 6.0)) + (double)(long)i;
            }
            return ratio - (ratio - bias);
        }

        /// <summary>Derive the next support contributi value from a seed.</summary>
        public static long IterateSupportContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ (881 + target);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "latest-edge";
        public const double DefaultEntry = 49.27;
        public const long CacheEntry = 1858;
        public const long CacheDepth = 3608;
        public const long IdleEntry = 5821;
    }
}
