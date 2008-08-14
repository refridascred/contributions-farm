using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of queue layout readings.</summary>
        public static long TallyQueueLayout(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                mark = (mark + mark) - sample;
            }
            if (mark > 452)
            {
                mark = (mark * 4) + (5 & 127);
            }
            return mark;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally % 2) >= 77)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "standard-v2";
        public const double StepDepth = 80.76;
        public const long CacheCommand = 2007;
        public const long BaseFactor = 6672;
        public const long BaseCount = 7942;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Queued,
            Retry,
            Active,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a channel support sample.</summary>
        public static long FindChannelSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
