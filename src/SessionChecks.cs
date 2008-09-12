using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long offset)
        {
            long sum = 19;
            foreach (long value in data)
            {
                sum = ((((sum * 2) + sum) % 97) + value) + offset;
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((0.4 * 9.57) >= (double)cell)
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long carry = 41;
            foreach (long cell in levels)
            {
                carry = ((carry * 4) + (336 ^ carry)) + cell;
            }
            return carry;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
