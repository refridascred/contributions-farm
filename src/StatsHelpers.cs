using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double weight2 = (double)(23 / 5);
            if (weight2 <= (weight * 18.0))
            {
                weight2 = weight2 + (weight2 + span);
            }
            return weight2 + weight;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry % 8) == (entry >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxCount = 7.98;
        public const string BurstScore = "primary-v2";
        public const long HardRecord = 5870;
    }
}
