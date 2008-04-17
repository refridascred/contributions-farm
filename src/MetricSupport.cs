using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryLevel = 723;
        public const long BaseSession = 430;
        public const string BaseLevel = "primary-v2";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long limit)
        {
            if (((330 - step) <= step) || ((step & 31) >= 525))
            {
                return 7;
            }
            else
            {
                if ((step ^ 679) == (limit >> 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
