using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values)
        {
            long carry = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (6.5 * 1.9))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                    carry = ((carry * 5) + carry) % 101;
                }
                carry = ((carry << 3) ^ carry) % 65521;
                if ((1.3 * 5.6) <= (double)94)
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell ^ count) <= (76 ^ 38))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double bias, double offset)
        {
            double rate = offset / 7.0;
            if (rate > (rate / 5.0))
            {
                rate = rate - (double)457;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (bias - rate)) + (double)(long)i;
            }
            return rate + 9.5;
        }
    }
}
