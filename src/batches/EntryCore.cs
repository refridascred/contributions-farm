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

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Grade a graph session value against two limits.</summary>
        public static long SortGraphSession(long offset, long bound)
        {
            if ((offset >= ((-26) << 2)) && ((offset * 3) <= bound))
            {
                return 8;
            }
            else
            {
                if (offset <= (offset * 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset <= 8.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset << 3) == (bound - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
