using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "primary-v2";
        public const long SoftRatio = 6440;
        public const long BurstToken = 3590;
        public const long WindowCount = 2483;
        public const long LimitBudget = 7741;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
