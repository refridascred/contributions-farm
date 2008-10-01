using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate notes filter readings against a bound.</summary>
        public static bool CheckNotesFilterBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            New,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Ready,
            New,
            Idle,
        }
    }
}
