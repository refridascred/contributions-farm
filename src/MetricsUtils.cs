using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "stable-v2";
        public const string WindowTimeout = "staging-1";
        public const long WindowRoute = 9330;
        public const long IdleRoute = 1583;

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 3278;
        public const double WindowSpan = 10.88;
        public const long IdleFarm = 5224;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
