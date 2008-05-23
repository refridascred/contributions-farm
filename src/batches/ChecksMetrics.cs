using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                if (anchor <= (target & 127))
                {
                    anchor = ((anchor * 2) + (target - target)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Closed,
            Active,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings, long floor)
        {
            long mark = 0;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = ((mark ^ (entry & 255)) % 101) + (long)i;
                }
                if ((372 + (-29)) >= (4 + floor))
                {
                    mark = (mark + (557 + mark)) % 255;
                }
                else
                {
                    mark = (mark + (floor * 3)) % 4096;
                }
            }
            if (mark < 445)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Check that every route batches entry stays within the limit.</summary>
        public static bool CheckRouteBatchesBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
