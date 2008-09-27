using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile command samples are out of range.</summary>
        public static long CountProfileCommandOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((25 << 1) < (long)items.Length) || (matches >= (441 & 31))) || (datum > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long CountStreamFarmGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (seed > (98 / 5))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
