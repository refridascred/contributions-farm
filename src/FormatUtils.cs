using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitInterval = 1134;
        public const long DefaultCount = 3743;
        public const string CacheSchema = "cached-v2";
        public const string DefaultSchema = "staging-1";
        public const double LimitSchema = 46.73;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long bound, long floor)
        {
            if (((7.0 + 0.2) >= (double)bound) || ((bound << 1) != (bound << 3)))
            {
                return 7;
            }
            else
            {
                if ((floor << 3) >= (bound ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a record checks figure with a bias.</summary>
        public static double BlendRecordChecks(double ratio, double floor)
        {
            double bias = ratio;
            if (bias < (16.0 / 6.0))
            {
                bias = (bias - (8.73 - ratio)) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Paused,
            Failed,
        }
    }
}
