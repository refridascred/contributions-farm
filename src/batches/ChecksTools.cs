using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double mean = (double)63 / 4.0;
            return (mean + (span / 6.0)) + scale;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            New,
            Queued,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
