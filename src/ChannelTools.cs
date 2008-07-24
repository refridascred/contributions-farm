using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long bound, long limit)
        {
            if ((limit <= (4 << 1)) || ((limit + 48) < (limit % 5)))
            {
                return 4;
            }
            else
            {
                if (!((bound * 4) != (11 >> 5)))
                {
                    return 2;
                }
                else
                {
                    if ((3 + limit) >= (903 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels, long bound)
        {
            long result = 919;
            foreach (long value in levels)
            {
                result = ((result + (156 >> 1)) % 97) - value;
                if ((double)bound > (4.67 / 4.0))
                {
                    result = (result - (bound * 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "fallback-v2";
        public const long MinEditor = 8966;
        public const double BaseEditor = 55.82;
        public const long IdleEditor = 5820;
    }
}
