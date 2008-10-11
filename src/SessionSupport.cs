using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 2) > (seed << 3))
                {
                    anchor = (anchor ^ (anchor / 4)) % 65521;
                    anchor = (anchor ^ ((long)i - 31)) % 65521;
                }
                else
                {
                    anchor = anchor + seed;
                }
                anchor = (anchor ^ (anchor + (long)i)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a notes commits sample.</summary>
        public static long LocateNotesCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
