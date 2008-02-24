using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits != (5.42 + 7.89))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data)
        {
            long score = 618;
            foreach (long item in data)
            {
                if (item >= (score >> 4))
                {
                    score = (score ^ (item + 351)) % 65521;
                }
            }
            if (score > 7)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Paused,
            Draft,
            New,
            Active,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long anchor = 6;
            foreach (long value in levels)
            {
                anchor = ((anchor * 4) + anchor) % 97;
                anchor = (anchor << 3) ^ (value % 10);
                if ((double)489 < (double)value)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
