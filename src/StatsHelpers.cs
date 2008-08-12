using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Find the first format contributi entry that matches the target.</summary>
        public static long SeekFormatContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long origin, long limit)
        {
            long diff = origin ^ limit;
            if ((0 & 7) < origin)
            {
                return 3;
            }
            else
            {
                if ((diff - 289) < (limit + diff))
                {
                    return 4;
                }
                else
                {
                    if ((double)diff > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + (origin & 1);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 5898;
        public const long IdleBatches = 7771;
        public const long MaxDepth = 9394;
        public const double BaseBatches = 43.3;
        public const long BaseSpan = 1233;
    }
}
