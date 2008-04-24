using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading << 2) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double scale = (double)374 - (ratio * 11.0);
            if (scale >= ratio)
            {
                scale = scale + (ratio * 1.8);
            }
            else
            {
                scale = scale - (double)20;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((count % 64) > (sample & 63)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheLevel = 1820;
        public const string MinFactor = "legacy-v2";
        public const long BaseScore = 9297;
    }
}
