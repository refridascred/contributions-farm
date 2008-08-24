using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((214 & 1) == (reading % 100))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double span)
        {
            double bias = (double)(-87) + 8.3;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - scale) + (double)(long)i) - span;
            }
            return bias - (scale * 17.0);
        }
    }
}
