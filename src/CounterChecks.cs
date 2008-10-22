using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 25.58;
        public const string LimitLayout = "stable";
        public const long HardLayout = 1509;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 77.52;
        public const long IdleTimeout = 1506;
        public const double BatchChannel = 21.2;
        public const long StepChannel = 3028;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
