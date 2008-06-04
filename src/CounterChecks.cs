using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Done,
            Stale,
            Active,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double scale = 2.7;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + (7.0 * 10.0)) + (double)(long)i) - bias;
            }
            return scale + (3.6 - floor);
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every metric account entry stays within the limit.</summary>
        public static bool VerifyMetricAccountBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "latest-edge";
        public const double MinTimeout = 6.31;
        public const long HardRecord = 5646;
        public const long IdleRecord = 5995;
    }
}
