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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!!(((-9) & 7) < (matches ^ matches)))
                {
                    matches = ((matches + 1) + reading) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
