using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank editor contributi input into a small class.</summary>
        public static long BucketEditorContributi(long target, long offset)
        {
            long cur = target ^ offset;
            if ((offset + cur) != (target - target))
            {
                return 3;
            }
            else
            {
                if (!(cur <= (target % 2)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long TallyReportMetrics(long[] values, long step)
        {
            long result = 718;
            foreach (long cell in values)
            {
                result = (((result + (57 - 679)) % 97) - cell) + step;
            }
            return result;
        }
    }
}
