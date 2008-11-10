using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stats payload counter forward.</summary>
        public static long SeriesStatsPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 8809;
        public const long MinDepth = 5552;
        public const string SoftAccount = "open-1";
        public const long MinAccount = 3852;
        public const long LimitBudget = 5814;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            Active,
            Queued,
            Done,
        }
    }
}
