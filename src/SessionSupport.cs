using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((37 + value) > (value + value))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long origin, long origin2)
        {
            if ((origin2 + origin) > (origin - 9))
            {
                return 3;
            }
            else
            {
                if ((origin <= (origin2 << 3)) && ((origin2 + 9) != (origin2 + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 4) < origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
