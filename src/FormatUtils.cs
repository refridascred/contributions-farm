using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (45 >= (cell + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Stale,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            New,
            Done,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 6099;
        public const double DefaultAccount = 7.14;
        public const double BurstRatio = 42.23;
    }
}
