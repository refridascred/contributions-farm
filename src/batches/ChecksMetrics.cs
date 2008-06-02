using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches ^ matches) <= (90 >> 1))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series, long offset)
        {
            long anchor = 9;
            foreach (long reading in series)
            {
                if ((double)offset < 7.0)
                {
                    anchor = ((anchor << 3) ^ (offset & 15)) % 255;
                }
                if (reading < (offset + offset))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) >= (cell ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
