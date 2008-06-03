using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9034;
        public const long LimitSession = 5075;
        public const long WindowSession = 2675;
        public const double RetryRatio = 19.67;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen + entry) > (557 - 0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first batch schema entry that matches the target.</summary>
        public static long LocateBatchSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
