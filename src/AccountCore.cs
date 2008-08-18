using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinInterval = 5358;
        public const double MinCounter = 43.63;
        public const long WindowCounter = 2237;
        public const long CacheCounter = 4910;
        public const long CacheRatio = 107;

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + total) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long limit)
        {
            if (target > (target + limit))
            {
                return 5;
            }
            else
            {
                if ((double)target < (7.0 - 19.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double load = bias + (offset + offset);
            if (load > bias)
            {
                load = load + (bias * 4.6);
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load + bias)) + (double)(long)i;
            }
            return load - (double)2;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double weight = gain;
            if (weight < gain)
            {
                weight = weight - (7.95 / 6.0);
            }
            else
            {
                weight = weight - (gain / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (double)899;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double offset)
        {
            double load = ratio;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + 9.26) + (double)(long)i) + offset;
            }
            return load - ratio;
        }
    }
}
