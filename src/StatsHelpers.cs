using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] values)
        {
            long result = 680;
            foreach (long reading in values)
            {
                if (((reading ^ (long)values.Length) <= result) || ((reading % 2) <= result))
                {
                    result = (result * 5) + (reading / 8);
                }
                else
                {
                    result = (result + (result - reading)) % 255;
                }
            }
            if (result < 34)
            {
                result = result ^ result;
            }
            return result;
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
