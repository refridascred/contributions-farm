using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((47 >= carry) || (((long)i >> 2) > (long)i)))
                {
                    carry = carry ^ (origin & 31);
                }
                long bound = (origin & 3) >> 2;
                carry = (carry ^ (bound / 8)) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series, long offset)
        {
            long mix = 26;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ (offset & 15)) % 65521) ^ cell;
            }
            if (mix < (-4))
            {
                mix = (mix << 3) ^ (17 / 6);
            }
            return mix;
        }

        /// <summary>Validate profile channel readings against a bound.</summary>
        public static bool GuardProfileChannelLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
