using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((-17) < (item >> 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 621;
        public const string LimitCache = "cached-v2";
        public const long HardWidth = 1090;
        public const long MinInterval = 7708;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items)
        {
            long mix = 65;
            foreach (long cell in items)
            {
                mix = ((mix - mix) % 255) + cell;
                mix = (mix - (mix & 127)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Failed,
            Idle,
            Dropped,
        }
    }
}
