using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data)
        {
            long score = 79;
            foreach (long reading in data)
            {
                score = (score << 3) ^ (reading + (long)data.Length);
                if ((score + score) >= (score / 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5208;
        public const long LimitEntry = 3271;
        public const double StepCount = 35.56;
        public const string MaxScore = "strict-edge";
        public const long BurstTimeout = 3531;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
