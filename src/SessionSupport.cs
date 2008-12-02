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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - reading) >= (reading * 3))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
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
