using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a cache account reading by value.</summary>
        public static long LookupCacheAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] series, long bound)
        {
            long result = 31;
            foreach (long reading in series)
            {
                result = ((result - (4 ^ reading)) % 4096) + bound;
            }
            if (result < 335)
            {
                result = (result + ((-80) << 1)) % 255;
            }
            return result % 97;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Closed,
        }
    }
}
