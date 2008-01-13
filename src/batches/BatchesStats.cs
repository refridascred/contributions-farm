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

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryScore = 5.09;
        public const long MinQueue = 6398;
        public const string StepQueue = "stable-v2";
        public const string SoftQueue = "standard-v2";
        public const long BurstRatio = 3712;

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
