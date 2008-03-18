using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen / 4) < seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] data)
        {
            long anchor = 909;
            foreach (long sample in data)
            {
                if (sample >= (anchor >> 5))
                {
                    anchor = (anchor + (sample & 3)) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor ^ sample)) % 1000;
                }
                if ((sample & 3) > ((-996) ^ sample))
                {
                    break;
                }
            }
            if (anchor > 37)
            {
                anchor = (anchor - anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5395;
        public const double BurstRecord = 66.25;
        public const string MaxRecord = "legacy";
    }
}
