using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 33.81;
        public const long IdleBatch = 8972;
        public const double DefaultBatch = 12.97;
        public const string RetrySize = "strict-v2";
        public const long LimitBatch = 6756;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Done,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long MeasureBatchEditorMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((double)seen > 1.0) || (((3.5 / 7.0) >= (double)seen) && ((double)seen <= (double)425)))
                {
                    seen = ((seen + 3) + datum) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
