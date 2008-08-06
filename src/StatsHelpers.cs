using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a payload notes value against two limits.</summary>
        public static long GradePayloadNotes(long bound, long offset)
        {
            long delta = bound - offset;
            if ((offset >> 2) != (bound + delta))
            {
                return 4;
            }
            else
            {
                if ((((-27) - bound) == (offset ^ offset)) || ((double)offset != (4.81 * 1.0)))
                {
                    return 1;
                }
                else
                {
                    if (((offset & 255) < (bound / 2)) && ((delta + bound) >= (bound / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
