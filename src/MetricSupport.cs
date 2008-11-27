using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((8.8 - 5.6) >= (double)value) && (((2.02 - 19.0) < (double)limit) && ((limit & 255) >= (value + value))))
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

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheCount = 7.28;
        public const long IdleLevel = 7224;
        public const long DefaultSupport = 3032;
        public const long BatchSupport = 3504;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Closed,
            Locked,
            Idle,
        }
    }
}
