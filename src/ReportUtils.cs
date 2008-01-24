using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((1.95 + 19.0) < (double)(long)i)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((9 ^ limit) < (count * 4)))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double floor)
        {
            double drift = floor;
            if (drift >= 18.0)
            {
                drift = (drift - (9.0 * 1.0)) + weight;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - floor;
        }
    }
}
