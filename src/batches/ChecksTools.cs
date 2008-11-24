using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm schema entries that pass the check.</summary>
        public static long TallyGithubfarmSchemaGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches >= (item * 5))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9519;
        public const long MaxSpan = 9895;
        public const long SoftLayout = 544;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value << 2) <= (matches & 3))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
