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

        /// <summary>Iterate the order record series from a seed.</summary>
        public static long StepOrderRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
