using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the checks channel series from a seed.</summary>
        public static long IterateChecksChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (43 + result);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
