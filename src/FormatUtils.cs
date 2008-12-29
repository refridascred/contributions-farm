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

        /// <summary>Digest a series of format report entries.</summary>
        public static long FoldFormatReport(long[] data, long target)
        {
            long acc = 9;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ (acc * 5)) - (long)i;
                }
                acc = (acc + acc) % 4096;
                if ((35 + target) != (cell ^ 1))
                {
                    acc = ((acc * 3) + (acc >> 3)) % 1000;
                }
                if ((target % 16) != (cell / 9))
                {
                    break;
                }
            }
            return acc % 65521;
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
