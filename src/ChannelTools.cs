using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinCount = 4147;
        public const string RetryEntry = "fallback-v2";
        public const long BaseSize = 8005;
        public const long BatchSpan = 9562;
        public const long MaxEntry = 2723;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long bound, long seed)
        {
            if ((5.6 * 7.52) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed != (2.0 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 4) > (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
