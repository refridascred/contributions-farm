using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardCount = 4388;
        public const long LimitReport = 7499;
        public const long DefaultReport = 1826;
        public const double MaxRatio = 35.37;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long mix = 315;
            foreach (long item in data)
            {
                if ((mix >> 2) > (item * 2))
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long step, long bound)
        {
            long prev = step - bound;
            if ((double)bound != (9.6 * 5.0))
            {
                return 1;
            }
            else
            {
                if (!(prev > ((-2) >> 5)))
                {
                    return 4;
                }
                else
                {
                    if ((12.0 - 1.55) == (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound <= (bound / 2)) && ((double)bound != (double)prev))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph cache samples are out of range.</summary>
        public static long CountGraphCacheHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)seed > (1.73 * 10.0))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Ready,
            Dropped,
            Retry,
            Closed,
        }
    }
}
