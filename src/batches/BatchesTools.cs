using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit window record readings against a rule.</summary>
        public static long MeasureWindowRecordOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((4.16 / 9.0) <= (double)target))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "fallback-v2";
        public const double IdleScore = 5.55;
        public const double WindowScore = 39.71;
        public const long CacheSize = 9481;
        public const double StepSize = 44.04;
    }
}
