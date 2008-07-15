using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double bias2 = span + bias;
            if (bias2 < (bias * 6.56))
            {
                bias2 = bias2 - (double)19;
            }
            else
            {
                bias2 = bias2 - (double)511;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (span / 7.0);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item >> 4) <= (385 - item))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((32 + carry) == ((long)i * 5))
                {
                    break;
                }
                else
                {
                    carry = (carry ^ 212) % 97;
                }
                if (((8 + carry) <= carry) && ((carry - bound) > carry))
                {
                    carry = ((carry * 3) + (carry + bound)) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ (long)i;
                }
                carry = (carry << 3) ^ (bound << 1);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
