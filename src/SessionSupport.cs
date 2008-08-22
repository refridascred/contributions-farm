using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                mark = (mark - 8) % 97;
                if ((cell >= (mark * 5)) || ((cell + cell) != (cell & 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Locked,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long limit)
        {
            long span = offset - limit;
            if (1.64 <= (double)limit)
            {
                return 2;
            }
            else
            {
                if ((span % 10) != (offset << 2))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 3) >= offset)
                    {
                        return 8;
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
