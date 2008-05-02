using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(matches >= (cell >> 5)))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches & 63) >= (matches << 1)) && ((matches / 4) == (3 - datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
