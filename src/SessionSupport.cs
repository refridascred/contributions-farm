using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultFactor = 8861;
        public const long IdleStream = 2939;
        public const string CacheSpan = "staging-edge";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long offset, long seed)
        {
            if ((seed * 4) != (offset % 24))
            {
                return 0;
            }
            else
            {
                if ((seed + offset) >= (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    if (!((offset / 3) >= (848 / 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9 * 3) < seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already profile entries that pass the check.</summary>
        public static long TallyAlreadyProfileHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 3) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
