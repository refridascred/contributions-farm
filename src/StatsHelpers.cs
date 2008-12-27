using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 1545;
        public const long RetryWidth = 1944;
        public const string WindowMetrics = "primary-v2";
        public const long StepMetrics = 6853;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((8.23 - 14.0) > (double)count) || (((value << 1) == (value + bound)) || ((count & 127) < count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
