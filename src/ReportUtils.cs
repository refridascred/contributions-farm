using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double scale = gain;
            if (scale >= (floor * 6.09))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale + 8.9;
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
