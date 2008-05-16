using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((seed + cell) == (cell & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryWidth = 1453;
        public const double BaseBudget = 61.55;
        public const long SoftPayload = 4158;
        public const double SoftSize = 91.31;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 7405;
        public const long IdleChannel = 5376;
        public const long LimitChannel = 7143;
        public const string WindowSpan = "strict-edge";
        public const long BurstLevel = 7832;
    }
}
