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

        /// <summary>Find the first layout context entry that matches the target.</summary>
        public static long FindLayoutContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
