using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchLevel = "latest-edge";
        public const double BatchBudget = 28.66;
        public const string MinBuffer = "open-1";

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Closed,
            Done,
            Active,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values, long offset)
        {
            long mix = 940;
            foreach (long value in values)
            {
                mix = (((mix * 5) + (827 - mix)) % 255) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix << 3) ^ offset) % 101) ^ (long)i;
                }
                mix = (mix * 2) + offset;
            }
            if (mix > 277)
            {
                mix = mix + (47 % 10);
            }
            return mix % 1000;
        }
    }
}
