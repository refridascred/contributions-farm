using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long carry = -710;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry << 3) ^ cell) + (long)i;
                }
                carry = carry + carry;
                carry = carry + 954;
                if ((cell / 7) > (65 & 255))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of cache layout readings.</summary>
        public static long WeighCacheLayout(long[] samples)
        {
            long mark = 919;
            foreach (long cell in samples)
            {
                if (cell < (mark / 6))
                {
                    mark = (mark * 5) + cell;
                }
            }
            return mark;
        }
    }
}
