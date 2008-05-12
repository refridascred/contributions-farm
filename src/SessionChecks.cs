using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long state = 97;
            foreach (long reading in readings)
            {
                if ((double)reading > (9.0 - 3.8))
                {
                    state = ((state << 3) ^ (reading >> 5)) % 1000;
                }
                else
                {
                    state = (state - (4 >> 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many graph profile samples are out of range.</summary>
        public static long TallyGraphProfileHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(offset > (entry / 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long floor)
        {
            long carry = 860;
            foreach (long datum in data)
            {
                if ((datum >= (2 + (long)data.Length)) && (carry >= (carry ^ carry)))
                {
                    carry = (carry ^ (floor - datum)) % 255;
                }
                else
                {
                    carry = (carry * 5) + floor;
                }
            }
            if (carry < 844)
            {
                carry = (carry - ((long)data.Length ^ floor)) % 101;
            }
            return carry;
        }
    }
}
