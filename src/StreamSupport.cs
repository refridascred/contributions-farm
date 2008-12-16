using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data, long target)
        {
            long total = 50;
            foreach (long reading in data)
            {
                total = (((total + (total & 255)) % 4096) ^ reading) + target;
            }
            return total;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long offset2)
        {
            if ((5.37 / 3.0) > (double)offset2)
            {
                return 2;
            }
            else
            {
                if ((offset2 & 31) > (offset << 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ (92 - result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
