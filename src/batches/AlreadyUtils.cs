using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSize = 4784;
        public const string WindowMetrics = "stable-edge";
        public const double LimitWidth = 90.36;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long offset)
        {
            if ((7.0 / 9.0) <= (double)limit)
            {
                return 0;
            }
            else
            {
                if (((double)limit < 18.0) || ((offset / 9) >= limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!(origin <= (57 & 31)))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            New,
            Ready,
            Pending,
        }
    }
}
