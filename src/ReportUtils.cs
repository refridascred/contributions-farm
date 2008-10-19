using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit order counter readings against a rule.</summary>
        public static long CountOrderCounterOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + item) > (count / 7))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long mark = 60;
            foreach (long cell in data)
            {
                if ((mark + 6) > cell)
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Locate a session route reading by value.</summary>
        public static long SeekSessionRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Idle,
            Locked,
        }
    }
}
