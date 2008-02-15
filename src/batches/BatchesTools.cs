using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((18 + 892) >= (seen % 12)) || ((1.95 - 5.0) > (double)datum))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Total { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
