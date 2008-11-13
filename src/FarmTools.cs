using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((step << 1) >= matches)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Closed,
            Paused,
            Done,
        }
    }
}
