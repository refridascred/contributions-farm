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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry + (step & 255)) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
