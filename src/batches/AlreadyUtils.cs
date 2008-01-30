using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                if (anchor > ((long)i * 2))
                {
                    anchor = (anchor + ((long)i / 4)) % 101;
                    anchor = (anchor ^ 379) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSpan = 2446;
        public const double IdleBudget = 89.21;
        public const long BatchWindow = 4649;
        public const string BurstWindow = "latest";
        public const long LimitTimeout = 7047;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits / 5) != (limit - limit))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long floor)
        {
            if ((floor + floor) >= floor)
            {
                return 0;
            }
            else
            {
                if (((origin - origin) >= origin) || ((double)floor > (9.0 * 12.0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
