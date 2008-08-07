using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowTimeout = 34.06;
        public const long DefaultCount = 4634;
        public const long LimitSize = 1234;
        public const long DefaultProfile = 8777;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 36.11;
        public const long MinScore = 3075;
        public const long MaxSize = 1989;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
