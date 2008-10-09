using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many tools record samples are out of range.</summary>
        public static long MeasureToolsRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((double)matches > (19.0 + 13.0)))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a graph record figure with a bias.</summary>
        public static double ProjectGraphRecord(double rate, double span)
        {
            double drift = (double)(3 >> 4);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - rate) + (double)(long)i) + span;
            }
            return drift + (13.0 / 6.0);
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item ^ hits) == (hits & 127))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
