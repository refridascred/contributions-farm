using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double drift = (double)69 * 5.3;
            if (drift <= (double)60)
            {
                drift = (drift - (2.0 * 5.22)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span - 2.6)) - (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if (((1.6 + 4.23) > (double)target) && ((target << 1) <= ((long)i ^ (long)i)))
                {
                    total = (total - (total & 127)) % 101;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                long diff = (long)i;
                carry = (carry - (floor + floor)) % 255;
                if ((4.28 >= (double)diff) || (floor > (diff ^ (-243))))
                {
                    diff = (diff * 4) + (80 >> 1);
                    carry = (carry + (floor + diff)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + ((long)i + (long)i)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((limit / 4) != (mark + (long)i)))
                {
                    mark = (mark * 3) + (mark + (-9));
                }
                else
                {
                    mark = ((mark << 3) ^ (limit / 3)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
