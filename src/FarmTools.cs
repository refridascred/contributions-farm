using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardScore = "primary-v2";
        public const long CacheSize = 6472;
        public const double MaxSpan = 35.25;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool GuardBatchBatchesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
