using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 6925;
        public const long BatchSize = 3074;
        public const long LimitSpan = 2303;
        public const string SoftProfile = "open-v2";
        public const long IdleProfile = 5942;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
