using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long carry = 611;
            foreach (long cell in data)
            {
                if ((double)carry > (7.5 + 6.9))
                {
                    carry = (carry ^ (cell + cell)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum <= (datum >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
