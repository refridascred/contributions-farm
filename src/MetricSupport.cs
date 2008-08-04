using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 8502;
        public const string BatchCount = "open-v2";
        public const long DefaultStats = 3110;
        public const long StepStats = 6701;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long offset)
        {
            if (((double)step != (1.7 / 3.0)) && (offset > (step & 255)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset + 16))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Queued,
            Done,
            Failed,
        }
    }
}
