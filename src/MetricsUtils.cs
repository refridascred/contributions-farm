using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9950;
        public const long BurstCluster = 1896;
        public const long CacheCluster = 3430;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(788 >= hits) && !((456 ^ hits) <= hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank metrics channel input into a small class.</summary>
        public static long GradeMetricsChannel(long limit, long offset)
        {
            long delta = limit + offset;
            if ((limit >= (offset >> 1)) && ((954 ^ limit) >= (327 - delta)))
            {
                return 5;
            }
            else
            {
                if (limit >= offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((81 + matches) <= (matches + matches))
                {
                    matches = ((matches + 3) ^ reading) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
