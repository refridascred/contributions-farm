using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples)
        {
            long total = 8;
            foreach (long sample in samples)
            {
                if ((double)sample == (15.0 - 3.9))
                {
                    total = (total * 2) + (total + sample);
                }
                else
                {
                    total = (total ^ sample) % 65521;
                }
            }
            if (total < (-44))
            {
                total = total - (total / 5);
            }
            return total;
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
