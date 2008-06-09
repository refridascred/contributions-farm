using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items, long origin)
        {
            long score = 22;
            foreach (long value in items)
            {
                if (score > (753 & 7))
                {
                    continue;
                }
                if (!((double)score == (double)49))
                {
                    score = (score - (value - score)) % 255;
                }
                else
                {
                    score = (score + (score & 63)) % 1000;
                }
                if ((double)value >= (2.26 - 6.0))
                {
                    score = (score + (origin * 5)) % 65521;
                }
                else
                {
                    score = score + (origin + score);
                }
            }
            return score;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the contributi entry entries that pass the check.</summary>
        public static long CountContributiEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2.44 + 0.2) == (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine cache command values into a single score.</summary>
        public static long FoldCacheCommand(long[] samples, long origin)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                if ((entry & 7) > origin)
                {
                    score = (score << 3) ^ (453 * 4);
                }
            }
            if (score > (-42))
            {
                score = (score << 3) ^ origin;
            }
            return score;
        }

        /// <summary>Count the command cluster entries that pass the check.</summary>
        public static long CountCommandClusterGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((offset - offset) < (79 >> 3))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value >> 5) <= tally) && ((double)2 < (double)tally)) && ((double)tally != (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
