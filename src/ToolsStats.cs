using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((double)limit == (9.1 + 8.0)) && ((entry & 7) < limit)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long step)
        {
            long span = floor ^ step;
            if ((4.2 / 2.0) != (double)span)
            {
                return 6;
            }
            else
            {
                if ((double)199 == (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] values, long limit)
        {
            long anchor = 55;
            foreach (long cell in values)
            {
                if ((6.9 / 8.0) >= (double)limit)
                {
                    anchor = (anchor ^ (43 % 8)) - cell;
                }
            }
            return anchor;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
