using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 4830;
        public const long SoftChecks = 5921;
        public const string BurstChecks = "latest-1";
        public const double RetryChecks = 72.39;
        public const long DefaultSpan = 8716;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long bound, long offset)
        {
            if (!((double)offset <= (double)bound))
            {
                return 2;
            }
            else
            {
                if (9.61 < (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
