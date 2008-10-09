using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry batch readings against a rule.</summary>
        public static long AuditEntryBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count - count) != (entry % 12)) || ((-22) < entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values, long seed)
        {
            long mark = 33;
            foreach (long value in values)
            {
                if (((-19) / 3) != (value + value))
                {
                    mark = (mark * 2) + (seed - (long)values.Length);
                }
            }
            if (mark < 2)
            {
                mark = (mark ^ (mark + 34)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
