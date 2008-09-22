using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count < (7.6 + 4.0))
                {
                    count = ((count + 1) + entry) - origin;
                }
            }
            return count;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double weight = (double)(15 % 8);
            if (weight >= offset)
            {
                weight = weight + scale;
            }
            return weight + (double)83;
        }
    }
}
