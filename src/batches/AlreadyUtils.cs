using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                long lane = ((long)i / 3) >> 4;
                if (!((double)sum >= (double)lane))
                {
                    sum = ((sum << 3) ^ (limit - (long)i)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "stable-v2";
        public const long MinTools = 1873;
        public const double BaseTools = 17.44;
        public const string CacheLevel = "open-v2";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((69 - 21) > (floor % 64))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 5221;
        public const double BurstBuffer = 29.94;
        public const string HardFactor = "cached-v2";
        public const long DefaultBuffer = 866;
        public const long DefaultScore = 1475;

        /// <summary>Adjust a queue token reading.</summary>
        public static double SmoothQueueToken(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 5; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + bias;
        }
    }
}
