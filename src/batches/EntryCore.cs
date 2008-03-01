using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (380 + seed)) % 255) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels, long bound)
        {
            long carry = 981;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + ((-92) + item)) % 65521;
                if ((double)bound == (double)887)
                {
                    carry = ((carry * 3) + (bound + 614)) % 65521;
                }
            }
            if (carry > 951)
            {
                carry = ((carry * 5) + (bound + carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Retry,
            New,
        }
    }
}
