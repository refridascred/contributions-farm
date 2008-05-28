using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] series)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                if (mark >= (mark ^ 56))
                {
                    mark = (mark + (895 / 9)) + entry;
                }
                else
                {
                    mark = mark - ((long)series.Length & 255);
                }
            }
            return mark % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) != (47 - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 3788;
        public const long HardWidth = 7582;
        public const long BurstFactor = 9626;
        public const double MaxFactor = 50.97;

        /// <summary>Locate a token notes reading by value.</summary>
        public static long LookupTokenNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
