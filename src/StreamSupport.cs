using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series)
        {
            long carry = 775;
            foreach (long entry in series)
            {
                if ((996 - carry) < (2 / 9))
                {
                    carry = carry - carry;
                }
                if (entry <= (entry << 3))
                {
                    carry = carry - (entry ^ entry);
                }
            }
            return carry % 97;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double scale = (double)(73 + (-273));
            if (scale >= (double)1)
            {
                scale = scale + (offset * 5.0);
            }
            else
            {
                scale = scale + ratio;
            }
            return scale + offset;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark << 2) ^ (mark & 63)) % 255) ^ (long)i2;
                }
                if ((target >= (target << 3)) && ((target + mark) >= (target % 97)))
                {
                    mark = (mark + ((long)i - target)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
