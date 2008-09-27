using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)limit < (13.0 - 12.0))
                {
                    sum = ((sum << 2) ^ (limit % 24)) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (limit << 2)) % 4096;
                }
                sum = (sum - (sum ^ sum)) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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
