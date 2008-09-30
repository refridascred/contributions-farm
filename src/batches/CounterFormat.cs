using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool ValidateBatchCacheLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long floor)
        {
            if ((double)floor != (7.8 / 7.0))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) <= (floor / 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (3.91 - 7.3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double mean = (weight + weight) + offset;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (mean * 11.0)) + (double)(long)i;
            }
            return mean - offset;
        }
    }
}
