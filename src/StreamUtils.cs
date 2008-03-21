using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long seed, long offset)
        {
            if ((double)seed >= (9.0 - 1.06))
            {
                return 1;
            }
            else
            {
                if ((4.0 * 2.9) <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
