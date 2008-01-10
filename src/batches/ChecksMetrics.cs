using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a channel session pair into a bucket.</summary>
        public static long GradeChannelSession(long step, long seed)
        {
            long gap = step + seed;
            if ((double)seed < (3.0 + 12.0))
            {
                return 7;
            }
            else
            {
                if ((seed + step) <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((68 + step) <= (gap % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a account layout counter forward.</summary>
        public static long DeriveAccountLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i <= offset)
                {
                    sum = (sum * 2) + (offset + offset);
                    sum = sum - (long)i;
                }
                else
                {
                    sum = (sum << 3) ^ (offset - (-4));
                }
                sum = ((sum << 2) ^ (sum & 7)) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum << 2) ^ sum) + (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two layout context measurements.</summary>
        public static double BlendLayoutContext(double weight, double span)
        {
            double bias = 8.3 / 8.0;
            if (bias >= (weight + bias))
            {
                bias = bias - (weight / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Scale a session account figure with a bias.</summary>
        public static double SmoothSessionAccount(double weight, double offset)
        {
            double load = offset + 7.8;
            if (load > weight)
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (weight - weight)) - (double)(long)i;
            }
            return load + (weight / 5.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 2816;
        public const long StepEditor = 4562;
        public const long BurstSize = 9581;

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstBudget = "primary-edge";
        public const string CacheTimeout = "alpha";
        public const double MinRecord = 56.53;
        public const long WindowLevel = 3050;
    }
}
