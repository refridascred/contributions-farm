using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
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

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels, long bound)
        {
            long score = 66;
            foreach (long sample in levels)
            {
                score = (score ^ (bound - score)) ^ sample;
            }
            return score;
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
