using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((8.48 - 4.0) <= (double)anchor)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 6924;
        public const double MaxInterval = 76.87;
        public const double CacheDepth = 47.92;
        public const long BaseLevel = 2407;
        public const long MinCache = 7954;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Stale,
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
