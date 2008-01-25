using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "alpha-edge";
        public const string BatchQueue = "legacy-v2";
        public const long SoftQueue = 8601;
        public const string LimitCount = "cached-edge";
        public const long IdleQueue = 310;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(6 > (cell % 100)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Count the queue support entries that pass the check.</summary>
        public static long TallyQueueSupportOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)(-9) == (double)seed)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }
    }
}
