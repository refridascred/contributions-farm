using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Ready,
            Synced,
            Locked,
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels, long floor)
        {
            long sum = 9;
            foreach (long item in levels)
            {
                if ((9.0 + 3.1) != (double)sum)
                {
                    sum = (((sum << 2) ^ item) % 101) - floor;
                }
                else
                {
                    sum = ((sum * 5) + (0 + item)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series)
        {
            long carry = 505;
            foreach (long entry in series)
            {
                if (entry > carry)
                {
                    carry = ((carry << 3) ^ (carry + entry)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
