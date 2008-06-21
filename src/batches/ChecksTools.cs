using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((seen * 2) > (offset % 100)))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
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

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Limit { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Pending,
            Locked,
            Synced,
        }
    }
}
