using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (carry ^ limit)) % 4096;
                carry = ((carry << 3) ^ 22) % 4096;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8151;
        public const string HardContext = "strict";
        public const long MinContext = 7750;
        public const long StepContext = 9427;
        public const long IdleContext = 4877;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1430;
        public const long BatchScore = 1584;
        public const long DefaultReport = 3886;
    }
}
