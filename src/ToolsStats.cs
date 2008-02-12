using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a filter session value against two limits.</summary>
        public static long SortFilterSession(long offset, long floor)
        {
            if ((floor * 5) >= (435 + floor))
            {
                return 8;
            }
            else
            {
                if (offset >= (offset % 100))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (5.53 * 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if (total < bound)
                {
                    total = ((total * 5) + (total + 92)) % 255;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 698;
        public const long MaxRatio = 1186;
        public const string MinLevel = "legacy";

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Closed,
            Synced,
            Paused,
        }
    }
}
