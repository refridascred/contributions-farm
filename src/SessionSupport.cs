using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((101 ^ (long)i) != (seed + 3)))
                {
                    carry = carry - (seed - carry);
                    carry = (carry - (seed ^ seed)) % 4096;
                }
                if (!((9.62 / 3.0) != (double)seed))
                {
                    carry = carry ^ seed;
                    carry = (carry ^ (carry % 64)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a metric counter counter forward.</summary>
        public static long DeriveMetricCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = mark + (limit % 8);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double weight = ratio;
            return weight + (span - span);
        }
    }
}
