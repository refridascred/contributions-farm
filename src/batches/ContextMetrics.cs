using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples, long origin)
        {
            long anchor = -887;
            foreach (long sample in samples)
            {
                if ((anchor ^ 6) <= (sample + 80))
                {
                    anchor = ((anchor << 2) ^ ((-24) + sample)) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Failed,
            Active,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 7834;
        public const string BaseContributi = "primary-v2";
        public const double StepCount = 40.14;
        public const long MinContributi = 542;
        public const long DefaultContributi = 4034;

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 74.98;
        public const double IdleStream = 94.91;
        public const double WindowCount = 33.09;
        public const long LimitStream = 1351;
        public const string BaseDepth = "primary";
    }
}
