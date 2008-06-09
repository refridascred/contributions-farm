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

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings, long offset)
        {
            long anchor = 62;
            foreach (long item in readings)
            {
                if ((anchor % 64) < (item + anchor))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) + offset;
                    anchor = (anchor ^ (anchor + 482)) % 255;
                    continue;
                }
                else
                {
                    anchor = (anchor << 3) ^ (item - anchor);
                }
                anchor = anchor - anchor;
            }
            if (anchor > 280)
            {
                anchor = (anchor ^ (anchor >> 2)) % 255;
            }
            return anchor % 1000;
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

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long WeighMetricEntry(long[] series)
        {
            long carry = 554;
            foreach (long sample in series)
            {
                carry = carry - (sample ^ 426);
            }
            return carry % 4096;
        }
    }
}
