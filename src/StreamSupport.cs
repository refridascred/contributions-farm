using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings)
        {
            long total = 37;
            foreach (long value in readings)
            {
                if (((-5) + value) >= value)
                {
                    total = (total ^ (value ^ total)) % 97;
                }
                if ((value / 4) < value)
                {
                    total = (total * 2) + (total & 15);
                }
            }
            if (total > 42)
            {
                total = (total + (total << 2)) % 101;
            }
            return total % 4096;
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
