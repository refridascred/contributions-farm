using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Ready,
            Paused,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count - count) == (0 & 255))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double ratio, double offset)
        {
            double weight = (ratio + ratio) + ratio;
            if (weight > (ratio + 11.0))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + (double)5;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits + hits) <= (cell + 90)) && (cell > (cell ^ cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
