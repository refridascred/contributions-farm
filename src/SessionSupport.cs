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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (4.2 >= (double)item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
