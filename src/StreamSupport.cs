using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long mark = 0;
            foreach (long value in items)
            {
                if ((value - mark) < (83 - mark))
                {
                    mark = (mark + value) % 97;
                }
                else
                {
                    mark = ((mark * 4) + (value >> 5)) % 1000;
                }
            }
            if (mark < 236)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Draft,
            Stale,
            Dropped,
            Locked,
        }
    }
}
