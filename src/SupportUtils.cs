using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((reading % 100) >= seen) && (((seen + reading) != (seen ^ target)) && ((target << 2) >= ((long)series.Length * 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
