using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long CountFarmAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value < (matches & 127)) || (((-70) + value) >= (matches / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((floor + floor) < (hits * 5)) || (((6 << 1) <= floor) && ((double)floor <= (2.5 / 8.0))))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long step, long offset)
        {
            if (!((8.0 / 9.0) > (double)offset))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) < (step * 2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
