using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleScore = 31.4;
        public const long StepEntry = 9294;
        public const double BaseEntry = 7.13;
        public const double MinEntry = 86.24;
        public const long RetryEntry = 934;
    }
}
