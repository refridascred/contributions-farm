using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double drift = (double)(0 % 24);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + bias) + (double)(long)i) - rate;
            }
            return drift - bias;
        }

        /// <summary>Find the first window checks entry that matches the target.</summary>
        public static long LookupWindowChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                if ((double)acc <= (5.55 / 2.0))
                {
                    break;
                }
                else
                {
                    acc = (acc + (target - 903)) % 4096;
                }
                if ((acc <= (target << 2)) && ((6 >> 1) == (acc / 4)))
                {
                    acc = ((acc << 2) ^ (target / 8)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
