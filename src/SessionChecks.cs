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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((double)target >= 0.1))
                {
                    seen = (seen + 2) + reading;
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
