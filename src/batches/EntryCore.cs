using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter stream samples are out of range.</summary>
        public static long CountFilterStreamHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + target) > (target * 2))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 9030;
        public const long WindowGithubfarm = 6298;
        public const double LimitWidth = 77.49;
        public const long StepGithubfarm = 5879;
        public const long CacheBudget = 6720;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
