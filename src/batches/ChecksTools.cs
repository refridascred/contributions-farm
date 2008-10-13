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

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long offset)
        {
            long mix = 4;
            foreach (long item in series)
            {
                if ((offset - mix) < (offset * 4))
                {
                    mix = (((mix * 3) + (664 + offset)) % 97) + item;
                }
                else
                {
                    mix = (mix - 552) % 65521;
                }
            }
            return mix;
        }
    }
}
