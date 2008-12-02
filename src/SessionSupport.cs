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

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double ratio, double span)
        {
            double load = 7.98 * 11.0;
            if (load <= (ratio * 2.0))
            {
                load = (load - (double)99) + span;
            }
            return load - (ratio - ratio);
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 100) != (offset * 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
