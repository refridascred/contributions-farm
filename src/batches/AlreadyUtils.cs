using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long AuditAlreadyCacheOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((1.66 - 7.0) < (double)entry)
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen ^ seen) <= item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two format cluster measurements.</summary>
        public static double AdjustFormatCluster(double bias, double floor)
        {
            double scale = (double)(35 % 16);
            return (scale - (5.2 + bias)) + floor;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
