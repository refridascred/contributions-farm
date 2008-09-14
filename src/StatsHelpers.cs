using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 1021;
        public const double IdleDepth = 57.42;
        public const double LimitMetrics = 40.0;
        public const string CacheMetrics = "local";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster batches samples.</summary>
        public static long TallyClusterBatches(long[] values)
        {
            long sum = -7;
            foreach (long sample in values)
            {
                if (((sum + 78) >= (sum % 8)) || ((sample * 3) <= sum))
                {
                    sum = sum - (sum + sample);
                }
            }
            if (sum > 913)
            {
                sum = (sum ^ (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "open-edge";
        public const double WindowNotes = 25.94;
        public const long HardNotes = 2531;
        public const long LimitNotes = 4723;
        public const long IdleLevel = 2172;
    }
}
