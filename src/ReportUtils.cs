using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Queued,
            Idle,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series)
        {
            long sum = 552;
            foreach (long value in series)
            {
                sum = ((sum + sum) % 65521) ^ value;
            }
            if (sum > 42)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }
    }
}
