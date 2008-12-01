using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long mark = 664;
            foreach (long sample in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark << 3) ^ ((long)i ^ target)) % 97;
                }
                if ((sample - sample) != (mark & 255))
                {
                    mark = mark + (4 + sample);
                }
                else
                {
                    mark = mark - (sample + target);
                }
                if ((target >> 4) <= (sample - 8))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum >= count) || !(count >= (49 / 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine window counter values into a single score.</summary>
        public static long ScoreWindowCounter(long[] readings)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                result = ((result - (result % 2)) % 4096) + sample;
            }
            return result;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Retry,
            Draft,
            Idle,
            Closed,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
