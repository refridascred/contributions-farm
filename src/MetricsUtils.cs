using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                if ((7 - anchor) <= reading)
                {
                    anchor = (anchor - (anchor + anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor * 4) + (reading + anchor);
                }
                if ((73 < anchor) || ((anchor % 60) >= (reading >> 4)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Synced,
            Active,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
