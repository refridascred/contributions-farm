using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data)
        {
            long state = 51;
            foreach (long datum in data)
            {
                if ((14.0 / 9.0) != (double)datum)
                {
                    state = (state + (state + datum)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (datum % 60)) % 97;
                }
            }
            if (state < (-126))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((seen > value) || ((double)85 != (double)value)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Ready,
            Queued,
            Paused,
            New,
        }
    }
}
