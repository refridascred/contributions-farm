using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((total + floor) > floor)
                {
                    total = (total - 739) % 101;
                    total = (total - total) % 1000;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count >= (count + count))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Draft,
            Done,
            Queued,
            Locked,
        }
    }
}
