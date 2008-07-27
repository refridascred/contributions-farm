using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleRatio = "cached-edge";
        public const string CacheTimeout = "standard-1";
        public const string MinEditor = "open";
        public const long BatchWidth = 438;
        public const long BurstEditor = 4244;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values)
        {
            long acc = 5;
            foreach (long cell in values)
            {
                if ((cell + acc) <= (acc ^ acc))
                {
                    acc = acc ^ (acc / 2);
                    acc = acc ^ (cell + acc);
                    break;
                }
                if ((cell + acc) <= (cell % 97))
                {
                    acc = (acc - (acc ^ acc)) % 101;
                }
            }
            return acc % 97;
        }
    }
}
