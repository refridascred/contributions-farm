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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((value << 3) < 99) || ((count % 60) > (count ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
