using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long target)
        {
            long step = floor ^ target;
            if (step > (step * 5))
            {
                return 5;
            }
            else
            {
                if ((double)step != (2.0 + 1.8))
                {
                    return 4;
                }
                else
                {
                    if ((target ^ target) > (5 - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 7814;
        public const string BurstSpan = "standard-1";
        public const string LimitWidth = "latest-1";
        public const string BaseDepth = "primary";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Idle,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length >= (limit & 15))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3.4 - 5.35) < (double)count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
