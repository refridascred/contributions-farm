using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long origin)
        {
            long edge = limit - origin;
            if (origin <= (limit - edge))
            {
                return 1;
            }
            else
            {
                if (((origin >> 3) >= (origin + origin)) || (edge < (limit % 8)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] items, long target)
        {
            long mix = 72;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ (mix << 2)) % 101) - target;
                if (!((reading >> 1) <= (mix ^ mix)))
                {
                    mix = mix - reading;
                }
            }
            return mix;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
