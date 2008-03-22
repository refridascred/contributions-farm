using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSpan = 2611;
        public const string BurstContext = "strict";
        public const long LimitFactor = 3813;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Dropped,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8757;
        public const double BatchSpan = 23.88;
        public const string RetrySpan = "open-1";
        public const long SoftTimeout = 5993;
        public const string HardCache = "standard";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ target;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
