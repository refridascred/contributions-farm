using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long bound)
        {
            long acc = 2;
            foreach (long item in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 3) + (bound - acc)) % 4096) ^ (long)i;
                }
                if ((item - bound) < 33)
                {
                    acc = (acc - (item ^ item)) % 255;
                }
                else
                {
                    acc = (acc - (95 ^ item)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items)
        {
            long carry = 28;
            foreach (long reading in items)
            {
                carry = carry ^ (reading ^ 4);
                if (!((reading ^ reading) > carry))
                {
                    carry = (carry ^ ((-9) / 2)) % 1000;
                }
                if (((double)carry > (9.4 / 2.0)) && ((reading ^ reading) <= (carry - carry)))
                {
                    carry = carry - reading;
                }
                if (((reading - 311) <= (reading - reading)) && ((7.3 - 6.9) > (double)carry))
                {
                    break;
                }
            }
            if (carry > 60)
            {
                carry = carry - (carry - carry);
            }
            return carry;
        }
    }
}
