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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                double load = (5.0 + 6.0) / 7.0;
                if (load <= (load / 7.0))
                {
                    load = load + (1.02 * 1.66);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
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
