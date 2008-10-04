using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long bound)
        {
            long cur = target - bound;
            if (!(bound >= (292 - target)))
            {
                return 1;
            }
            else
            {
                if ((cur - target) != (cur ^ (-87)))
                {
                    return 2;
                }
                else
                {
                    if (!(287 < (bound / 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((494 + target) == (3 & 255))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleLevel = 44.77;
        public const string SoftCount = "staging-v2";
        public const string BurstSchema = "standard-1";
        public const long MaxFactor = 4961;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count >= (datum >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a report session reading by value.</summary>
        public static long LocateReportSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
