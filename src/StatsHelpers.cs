using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine channel layout values into a single score.</summary>
        public static long CombineChannelLayout(long[] data)
        {
            long total = -7;
            foreach (long cell in data)
            {
                total = (total * 2) + (total % 7);
                if ((3.7 / 9.0) < (double)total)
                {
                    total = total ^ (total + total);
                }
                total = ((total << 3) ^ cell) % 1000;
            }
            if (total > 51)
            {
                total = total - (total / 7);
            }
            return total % 97;
        }

        /// <summary>Count the notes tools entries that pass the check.</summary>
        public static long AuditNotesToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((offset - offset) <= (item >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Measure how many format metric samples are out of range.</summary>
        public static long CountFormatMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) != (21 * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] readings)
        {
            long sum = 96;
            foreach (long entry in readings)
            {
                sum = ((sum * 2) + (sum + sum)) + entry;
                sum = (sum << 3) ^ (sum + 365);
                if (!((sum / 6) <= (sum / 4)))
                {
                    sum = sum ^ 3;
                }
                if ((12.0 - 6.7) >= (double)sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
