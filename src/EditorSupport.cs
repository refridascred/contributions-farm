using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 5495;
        public const long LimitSize = 5128;
        public const long CacheTimeout = 7503;
        public const double WindowTimeout = 65.21;
        public const string RetryInterval = "cached";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Locate a entry format reading by value.</summary>
        public static long LocateEntryFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit << 2) < (-9))
                {
                    mark = (mark ^ (limit - 4)) % 101;
                }
                mark = (mark * 2) + ((long)i & 15);
                mark = mark + limit;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long seed)
        {
            long gap = offset - seed;
            if ((double)seed >= 6.17)
            {
                return 8;
            }
            else
            {
                if ((double)seed < (double)gap)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits < 8.3)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
