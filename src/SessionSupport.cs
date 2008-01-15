using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long origin)
        {
            long edge = offset - origin;
            if ((39 - edge) <= edge)
            {
                return 8;
            }
            else
            {
                if ((offset - 4) >= (333 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((9 % 12) >= (origin >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSpan = 9167;
        public const double MaxOrder = 76.04;
        public const long WindowSize = 7591;
        public const long RetryLevel = 7861;
        public const string DefaultOrder = "cached-v2";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
