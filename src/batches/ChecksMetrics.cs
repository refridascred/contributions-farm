using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine already route values into a single score.</summary>
        public static long FoldAlreadyRoute(long[] data)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                if (((entry + anchor) < entry) || ((double)anchor >= (2.86 - 5.18)))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardRatio = 6720;
        public const double DefaultInterval = 58.47;
        public const long BaseSpan = 5361;

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels)
        {
            long acc = 8;
            foreach (long entry in levels)
            {
                if ((acc & 3) > acc)
                {
                    acc = ((acc << 2) ^ entry) % 4096;
                }
            }
            if (acc < (-757))
            {
                acc = (acc * 3) + (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry - 803))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)offset >= (1.0 + 4.43))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
