using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target & 31) <= value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
