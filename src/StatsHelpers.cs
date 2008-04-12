using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 54.75;
        public const long MaxLayout = 6675;
        public const string LimitSize = "fallback";
        public const long HardSize = 7914;
        public const long SoftLayout = 5053;

        /// <summary>Rank tools route input into a small class.</summary>
        public static long SortToolsRoute(long step, long limit)
        {
            long offset = step ^ limit;
            if ((offset % 24) >= limit)
            {
                return 5;
            }
            else
            {
                if ((double)offset != (5.4 / 3.0))
                {
                    return 2;
                }
                else
                {
                    if (((limit + step) > step) || (limit < (offset << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a filter token reading by value.</summary>
        public static long FindFilterTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }
    }
}
