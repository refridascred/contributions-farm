using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 743;
        public const double RetrySession = 90.5;
        public const long IdleFactor = 8946;
        public const long BaseSession = 7948;
        public const double CacheSession = 48.66;

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long limit, long bound)
        {
            if ((bound & 127) != (bound / 2))
            {
                return 1;
            }
            else
            {
                if (!((5.29 * 7.0) <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit already graph readings against a rule.</summary>
        public static long CountAlreadyGraphMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
