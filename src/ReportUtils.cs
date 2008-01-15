using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0 - offset) <= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile payload series from a seed.</summary>
        public static long DeriveProfilePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the route farm series from a seed.</summary>
        public static long RollRouteFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (carry > 42)
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 101;
                    carry = carry ^ (carry - carry);
                }
                carry = (carry << 2) ^ bound;
                carry = carry ^ (8 % 64);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = span;
            if (gain > span)
            {
                gain = (gain + (double)4) - rate;
            }
            return gain - gain;
        }
    }
}
