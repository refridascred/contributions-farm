using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinTimeout = 15.68;
        public const string BatchCommits = "alpha-v2";
        public const long HardCommits = 3869;
        public const long DefaultCommits = 6230;
        public const long BatchDepth = 1465;

        /// <summary>Count the metric graph entries that pass the check.</summary>
        public static long TallyMetricGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
