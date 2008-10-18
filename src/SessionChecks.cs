using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Level { get; set; }
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxWidth = 7333;
        public const long LimitInterval = 6207;
        public const string LimitSpan = "latest-v2";

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series, long floor)
        {
            long total = 94;
            foreach (long value in series)
            {
                total = ((total - (total - floor)) % 1000) - value;
            }
            return total;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
