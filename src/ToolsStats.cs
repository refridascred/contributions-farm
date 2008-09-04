using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 8984;
        public const long HardCounter = 9173;
        public const long SoftCounter = 6696;
        public const long StepSize = 5466;
        public const long WindowCounter = 4455;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2856;
        public const long SoftWidth = 7942;
        public const long RetryBatch = 8369;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 3726;
        public const long HardCount = 319;
        public const long StepCommits = 490;
        public const double BatchCommits = 20.38;

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (bias2 - rate))
            {
                bias2 = bias2 - (bias + bias);
            }
            return bias2 - (rate - 1.1);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardTimeout = 86.6;
        public const string BaseSpan = "alpha-edge";
        public const double SoftReport = 82.83;
        public const string LimitFactor = "fallback-v2";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((16.0 / 5.0) >= (double)hits))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
