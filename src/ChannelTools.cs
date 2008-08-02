using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "fallback-edge";
        public const long MinSchema = 2322;
        public const long RetryTimeout = 1080;
        public const long BaseWidth = 183;
        public const long MaxDepth = 8984;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (1.66 - 4.94))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
