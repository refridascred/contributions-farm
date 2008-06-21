using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Ratio { get; set; }
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Accumulate record support samples.</summary>
        public static long FoldRecordSupport(long[] series)
        {
            long anchor = 32;
            foreach (long datum in series)
            {
                long offset = (datum / 9) << 2;
                if (datum <= offset)
                {
                    offset = (offset - (offset - offset)) % 4096;
                    continue;
                }
                else
                {
                    anchor = (anchor * 5) + ((-39) >> 2);
                    offset = ((offset * 4) + (9 % 64)) % 4096;
                }
                anchor = (anchor + (datum * 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSpan = 1794;
        public const long HardDepth = 1126;
        public const long MinBudget = 393;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
