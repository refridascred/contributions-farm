using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the window record series from a seed.</summary>
        public static long SeriesWindowRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 2) ^ (result & 15)) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of channel schema entries.</summary>
        public static long TotalChannelSchema(long[] values, long seed)
        {
            long carry = 1;
            foreach (long datum in values)
            {
                if ((6 + carry) > (78 ^ datum))
                {
                    carry = carry + datum;
                }
            }
            if (carry > 59)
            {
                carry = (carry * 4) + (seed % 5);
            }
            return carry;
        }
    }
}
