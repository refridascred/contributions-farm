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

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items, long limit)
        {
            long mark = 803;
            foreach (long value in items)
            {
                if (!((limit << 1) >= mark))
                {
                    mark = (mark + (limit >> 4)) + value;
                }
                else
                {
                    mark = mark - limit;
                }
            }
            if (mark > 3)
            {
                mark = (mark + (limit - 25)) % 1000;
            }
            return mark;
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
