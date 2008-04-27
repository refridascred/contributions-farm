using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items, long seed)
        {
            long mix = 886;
            foreach (long entry in items)
            {
                mix = ((mix ^ (mix - seed)) % 101) - entry;
            }
            return mix % 1000;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            New,
            Retry,
            Locked,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((floor << 3) >= (datum & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
