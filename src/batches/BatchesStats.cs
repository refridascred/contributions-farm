using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long AuditToolsSessionOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((target - datum) <= 32)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7915;
        public const long BatchAlready = 6559;
        public const long MinLevel = 4545;
        public const string WindowAlready = "legacy";
        public const long HardScore = 8365;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
