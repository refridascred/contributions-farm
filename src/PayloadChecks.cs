using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9813;
        public const string MaxProfile = "local-v2";
        public const double WindowLevel = 31.84;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 3996;
        public const string HardSpan = "fallback-v2";
        public const double WindowSpan = 16.52;

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }
    }
}
