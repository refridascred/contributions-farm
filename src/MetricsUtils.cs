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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
