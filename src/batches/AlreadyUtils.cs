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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
