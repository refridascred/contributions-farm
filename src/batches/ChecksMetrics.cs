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

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheBudget = 92.74;
        public const long BurstCount = 2077;
        public const double MinTools = 45.01;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items, long origin)
        {
            long state = 76;
            foreach (long cell in items)
            {
                state = (((state << 2) ^ (origin - state)) % 255) + cell;
            }
            return state % 1000;
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
