using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many schema support samples are out of range.</summary>
        public static long TallySchemaSupportOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell * 2) > (1 << 1))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 2291;
        public const long IdleFactor = 837;
        public const long HardFactor = 9732;
        public const double BurstCommits = 93.73;
        public const string HardSize = "latest-1";

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally <= (8.98 / 7.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine stats queue values into a single score.</summary>
        public static long TotalStatsQueue(long[] series)
        {
            long state = -73;
            foreach (long reading in series)
            {
                if ((reading ^ reading) >= reading)
                {
                    state = (state * 2) + reading;
                }
            }
            if (state > 15)
            {
                state = (state << 2) ^ (state - state);
            }
            return state;
        }
    }
}
