using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((89 << 2) < seen)
                {
                    seen = ((seen + 2) + sample) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
