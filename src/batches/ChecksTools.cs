using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryTimeout = 4167;
        public const double DefaultBudget = 55.51;
        public const long IdleRatio = 5980;
        public const long RetryBatches = 9814;

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long offset)
        {
            long next = bound - offset;
            if (next <= (next - offset))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) <= 9)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long sum = 741;
            foreach (long value in series)
            {
                if ((3 / 5) == (sum ^ value))
                {
                    sum = ((sum * 2) + (298 + seed)) % 65521;
                }
                else
                {
                    sum = sum ^ (seed & 3);
                }
                if (value >= sum)
                {
                    sum = (sum ^ (seed ^ seed)) % 101;
                }
                if (sum <= (sum % 5))
                {
                    break;
                }
            }
            if (sum > 89)
            {
                sum = sum ^ (seed * 3);
            }
            return sum;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double bias, double bias2)
        {
            double drift = bias;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (drift + bias)) + (double)(long)i) + bias2;
            }
            return drift - (8.1 - drift);
        }
    }
}
