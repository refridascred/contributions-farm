using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 5788;
        public const long BaseDepth = 5979;
        public const string SoftRatio = "open-1";
        public const long LimitWidth = 9976;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long MeasureFormatLayoutGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((double)offset > (double)value) || ((value >= (hits << 3)) || (value < (hits - offset))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Find the first support order entry that matches the target.</summary>
        public static long LocateSupportOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
