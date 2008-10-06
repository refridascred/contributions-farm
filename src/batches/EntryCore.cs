using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] readings)
        {
            long acc = 40;
            foreach (long entry in readings)
            {
                acc = acc ^ entry;
                if (entry <= acc)
                {
                    break;
                }
            }
            if (acc < (-3))
            {
                acc = ((acc * 4) + (acc * 4)) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate order commits samples.</summary>
        public static long CombineOrderCommits(long[] samples, long origin)
        {
            long score = -408;
            foreach (long item in samples)
            {
                if (((-7) & 255) > score)
                {
                    score = ((score - (item + 7)) % 255) + origin;
                }
            }
            return score;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Stale,
            Ready,
        }
    }
}
