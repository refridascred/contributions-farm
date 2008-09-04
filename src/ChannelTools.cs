using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Ready,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheWidth = 8870;
        public const long RetryLevel = 9835;
        public const long BaseRatio = 3554;
        public const string BaseEntry = "alpha-1";
    }
}
