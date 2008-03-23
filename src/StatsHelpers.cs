using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            long delta = bound - seed;
            if ((bound - seed) > (delta - seed))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) <= (bound - delta))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long offset)
        {
            long mark = 457;
            foreach (long datum in items)
            {
                mark = ((mark << 3) ^ (mark % 2)) + offset;
                if ((6.4 * 7.0) == (double)mark)
                {
                    mark = mark - (mark ^ datum);
                }
                if (((datum + datum) <= mark) || ((-17) > (mark % 100)))
                {
                    mark = (mark - (mark - datum)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Done,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Pending,
            Paused,
            Locked,
            Closed,
        }
    }
}
