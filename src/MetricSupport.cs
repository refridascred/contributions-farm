using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 6056;
        public const string LimitSize = "fallback-edge";
        public const string SoftAlready = "strict-1";

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
