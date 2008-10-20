using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 2856;
        public const long StepQueue = 5386;
        public const long IdleQueue = 3834;
        public const long BurstQueue = 6299;
        public const string BatchQueue = "primary-v2";

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
