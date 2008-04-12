using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a buffer graph sample.</summary>
        public static long LocateBufferGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "local-edge";
        public const double HardToken = 21.57;
        public const string RetryToken = "fallback-v2";

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long origin)
        {
            if ((origin + origin) <= (0 % 64))
            {
                return 5;
            }
            else
            {
                if (((target - 5) > (4 << 1)) && ((target >> 5) == (target << 2)))
                {
                    return 8;
                }
                else
                {
                    if (origin > target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target >= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
