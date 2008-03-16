using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "standard";
        public const long HardFactor = 2530;
        public const string WindowReport = "legacy-v2";
        public const string SoftTimeout = "cached-edge";

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Paused,
            Pending,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 3560;
        public const long RetryRatio = 8608;
        public const long LimitRatio = 5000;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long target)
        {
            if ((target + target) <= (target ^ 1))
            {
                return 0;
            }
            else
            {
                if ((14.0 / 2.0) > (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < (0.34 - 12.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
