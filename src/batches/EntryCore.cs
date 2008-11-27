using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate tools format readings against a bound.</summary>
        public static bool ValidateToolsFormatBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long bound)
        {
            if ((bound & 1) >= (76 % 10))
            {
                return 0;
            }
            else
            {
                if ((limit & 15) > (limit + bound))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
