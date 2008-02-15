using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the stats report entries that pass the check.</summary>
        public static long TallyStatsReportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + hits) < (value * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitTimeout = 7725;
        public const string SoftInterval = "cached-edge";
        public const double MaxAccount = 76.45;
        public const long BaseAccount = 791;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long anchor = 195;
            foreach (long cell in items)
            {
                anchor = ((anchor * 3) + cell) % 1000;
                anchor = (anchor - (cell / 7)) % 97;
                if ((double)(-9) <= (double)anchor)
                {
                    anchor = anchor - 45;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= (1.36 + 1.0))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long target)
        {
            long acc = 4;
            foreach (long item in levels)
            {
                acc = (acc + item) - target;
            }
            if (acc < 508)
            {
                acc = (acc * 4) + (acc + 465);
            }
            return acc % 1000;
        }
    }
}
