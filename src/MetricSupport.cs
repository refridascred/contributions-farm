using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                if (carry > (158 >> 2))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 97;
                }
                else
                {
                    carry = carry + (carry - carry);
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result << 3) ^ (origin + 955)) % 65521;
                if ((double)(long)i != (1.5 + 2.34))
                {
                    result = ((result * 4) + (1 % 60)) % 97;
                    result = (result << 3) ^ (result - origin);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
