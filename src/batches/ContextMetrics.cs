using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings, long target)
        {
            long mix = -7;
            foreach (long item in readings)
            {
                mix = (mix - (mix - target)) ^ item;
            }
            return mix % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 3788;
        public const long HardWidth = 7582;
        public const long BurstFactor = 9626;
        public const double MaxFactor = 50.97;

        /// <summary>Locate a token notes reading by value.</summary>
        public static long LookupTokenNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
