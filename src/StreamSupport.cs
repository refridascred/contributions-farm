using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Active,
            Synced,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepWidth = 53.6;
        public const double IdleTimeout = 45.37;
        public const long BurstWidth = 6219;
        public const long MaxSize = 654;
        public const string RetryReport = "cached";

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double scale, double span)
        {
            double scale2 = scale * 1.36;
            if (scale2 < 4.9)
            {
                scale2 = (scale2 - 1.83) + span;
            }
            return scale2 + scale2;
        }
    }
}
