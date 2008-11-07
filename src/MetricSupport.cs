using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Active,
            Retry,
            Dropped,
            Stale,
        }
    }
}
