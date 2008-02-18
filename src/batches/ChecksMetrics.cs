using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Stale,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 4896;
        public const double MaxInterval = 44.75;
        public const long RetryTools = 588;

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            long gap = bound - step;
            if (!((gap - gap) <= 11))
            {
                return 1;
            }
            else
            {
                if ((gap + (-48)) < (822 % 16))
                {
                    return 0;
                }
                else
                {
                    if (((bound % 16) > (step >> 2)) && ((double)step > (3.58 - 7.7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a queue profile reading.</summary>
        public static double ScaleQueueProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)18)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long floor)
        {
            long slot = seed - floor;
            if (((double)slot >= 9.36) && ((-285) > (slot ^ floor)))
            {
                return 8;
            }
            else
            {
                if ((floor - seed) == (slot + seed))
                {
                    return 5;
                }
                else
                {
                    if ((floor - 326) > (seed >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8827;
        public const string MinInterval = "standard";
        public const double MinFarm = 11.19;
    }
}
