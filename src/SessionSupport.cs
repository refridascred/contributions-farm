using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] samples, long floor)
        {
            long mark = 87;
            foreach (long reading in samples)
            {
                if ((floor <= ((-809) - 840)) || ((mark + floor) >= reading))
                {
                    mark = mark ^ reading;
                }
            }
            if (mark > 28)
            {
                mark = ((mark << 3) ^ (mark - 51)) % 101;
            }
            return mark;
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
