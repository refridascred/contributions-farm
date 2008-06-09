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

        /// <summary>Derive the next already payload value from a seed.</summary>
        public static long SeriesAlreadyPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((2.98 * 4.44) < (double)tally)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
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
