using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 1.81;
        public const long MinRatio = 6601;
        public const string StepMetrics = "local-edge";
        public const double MaxMetrics = 9.19;
        public const string LimitRatio = "legacy-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "open-edge";
        public const string BaseCount = "latest-1";
        public const long WindowDepth = 3870;

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
