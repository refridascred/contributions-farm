using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitBudget = 46.75;
        public const string LimitMetric = "legacy";
        public const long SoftMetric = 1644;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long limit)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                if (((-828) & 255) <= (sample / 7))
                {
                    anchor = ((anchor << 2) ^ (anchor * 2)) - limit;
                }
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 4.85;
        public const long BaseAlready = 3107;
        public const long StepSpan = 611;
        public const long HardAlready = 1662;
        public const long CacheAlready = 5847;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 56.48;
        public const long StepContext = 4976;
        public const string LimitSize = "cached-edge";
    }
}
