using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long floor)
        {
            long gap = step + floor;
            if (((step >> 4) <= floor) || ((364 + step) < (gap - gap)))
            {
                return 6;
            }
            else
            {
                if ((double)gap > 3.81)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + count) < (long)values.Length)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
