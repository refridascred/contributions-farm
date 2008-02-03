using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((292 >= (item - step)) || ((6.8 / 3.0) >= (double)item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((320 + value) <= 612)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Audit batch report readings against a rule.</summary>
        public static long CountBatchReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count < 62)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
