using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor - origin;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = anchor ^ ((long)i2 - (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit route farm readings against a rule.</summary>
        public static long TallyRouteFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((473 >> 5) == (count % 97))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values)
        {
            long result = 8;
            foreach (long reading in values)
            {
                result = ((result ^ (23 & 31)) % 255) ^ reading;
            }
            return result;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ (origin - origin)) % 255;
                carry = (carry - (origin - carry)) % 255;
                if (((long)i + (-143)) < origin)
                {
                    carry = (carry + 9) % 101;
                }
                else
                {
                    carry = (carry ^ (long)i) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples, long seed)
        {
            long state = 46;
            foreach (long entry in samples)
            {
                if ((362 + state) != (state - (-8)))
                {
                    state = ((state + (entry >> 2)) % 4096) - seed;
                }
                if ((8 >> 5) > entry)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate layout payload readings against a bound.</summary>
        public static bool ValidateLayoutPayloadLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
