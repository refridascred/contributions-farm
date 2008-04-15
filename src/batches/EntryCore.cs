using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Dropped,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long limit)
        {
            if ((target >> 2) != (target & 127))
            {
                return 7;
            }
            else
            {
                if ((target + target) != (87 ^ limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
