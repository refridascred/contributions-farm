using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double weight = bias;
            if (weight >= (double)9)
            {
                weight = (weight + (double)4) - offset;
            }
            return weight - weight;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5547;
        public const long HardBudget = 590;
        public const long BaseBudget = 678;
        public const long CacheFactor = 2853;
        public const long BurstBudget = 5955;

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double mean = (double)687 / 7.0;
            if (mean > 3.2)
            {
                mean = (mean - rate) + bias;
            }
            else
            {
                mean = mean + (mean * 6.43);
            }
            return mean - (6.0 - mean);
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long floor)
        {
            if ((floor - target) < (target + target))
            {
                return 2;
            }
            else
            {
                if ((floor ^ floor) >= (floor & 7))
                {
                    return 8;
                }
                else
                {
                    if ((double)target < (2.03 * 8.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9267;
        public const string HardInterval = "fallback";
        public const long MaxFactor = 5689;
        public const long CacheBudget = 7429;

        /// <summary>Iterate the farm contributi series from a seed.</summary>
        public static long RollFarmContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (sum ^ (sum ^ origin)) ^ (long)i2;
                    sum = (sum + origin) % 1000;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    sum = ((sum ^ (794 % 64)) % 65521) - (long)i3;
                }
                if (((double)sum > (17.0 + 13.0)) && ((double)(long)i >= (7.41 - 1.29)))
                {
                    sum = sum - sum;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
