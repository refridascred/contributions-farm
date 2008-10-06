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

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                long step = (sample + carry) + (carry * 2);
                if ((carry + step) >= (sample / 6))
                {
                    break;
                }
                else
                {
                    step = step + (carry * 3);
                }
                if (!((double)sample >= 8.0))
                {
                    carry = (carry - (2 ^ sample)) % 1000;
                }
            }
            return carry;
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
