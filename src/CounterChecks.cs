using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Failed,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstDepth = "latest";
        public const long BaseSpan = 9613;
        public const long CacheCluster = 2977;
        public const double BaseTimeout = 22.01;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a commits report reading.</summary>
        public static double SmoothCommitsReport(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (weight / 2.0))
            {
                bias2 = bias2 + (double)43;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (bias2 * 0.06);
        }
    }
}
