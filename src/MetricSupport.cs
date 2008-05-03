using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long seed)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                if ((double)seed < (double)mark)
                {
                    mark = (mark ^ (mark * 3)) % 101;
                }
                else
                {
                    mark = (mark - (mark + reading)) % 4096;
                }
            }
            if (mark > 81)
            {
                mark = (mark + (mark / 4)) % 255;
            }
            return mark;
        }

        /// <summary>Roll a commits tools counter forward.</summary>
        public static long IterateCommitsTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = carry ^ (carry - 0);
                carry = (carry << 3) ^ carry;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
