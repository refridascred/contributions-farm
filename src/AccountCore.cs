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

        /// <summary>Iterate the layout entry series from a seed.</summary>
        public static long DeriveLayoutEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - (9 >> 5)) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + mark) % 4096;
                long matches = (mark + 349) % 2;
                if (((long)i - 3) < (matches + 423))
                {
                    mark = mark + (mark & 31);
                    matches = (matches + (matches ^ mark)) % 101;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
