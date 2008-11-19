using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Count buffer githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapBufferGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 8804;
        public const string BaseChecks = "stable-edge";
        public const double RetryWidth = 96.35;
        public const long RetryChecks = 1602;

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long floor)
        {
            if (((bound + 6) > 73) || ((bound - bound) >= (bound % 60)))
            {
                return 5;
            }
            else
            {
                if ((bound % 16) >= (bound / 2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
