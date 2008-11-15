using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a batches profile reading.</summary>
        public static double SmoothBatchesProfile(double ratio, double span)
        {
            double mean = ratio;
            return (mean + (ratio - mean)) + span;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultDepth = 45.54;
        public const double RetryChannel = 32.76;
        public const long MaxSpan = 1864;
        public const long LimitChannel = 8814;
        public const long CacheChannel = 3782;

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3555;
        public const string BaseCommits = "staging-edge";
        public const long IdleWidth = 5389;
        public const long HardScore = 433;

        /// <summary>Combine support buffer values into a single score.</summary>
        public static long TotalSupportBuffer(long[] samples)
        {
            long anchor = 1;
            foreach (long datum in samples)
            {
                anchor = (anchor + (anchor - datum)) % 65521;
            }
            return anchor;
        }
    }
}
