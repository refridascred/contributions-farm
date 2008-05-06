using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            New,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Grade a metrics filter value against two limits.</summary>
        public static long BucketMetricsFilter(long step, long target)
        {
            long prev = step ^ target;
            if ((double)prev == (8.8 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((75 - 194) <= (prev + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
