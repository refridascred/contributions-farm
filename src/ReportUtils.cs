using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate stream record samples.</summary>
        public static long TallyStreamRecord(long[] values, long target)
        {
            long sum = 657;
            foreach (long reading in values)
            {
                sum = (((sum ^ (sum >> 4)) % 101) - reading) + target;
            }
            if (sum > 798)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit already command readings against a rule.</summary>
        public static long MeasureAlreadyCommandOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((double)origin == (double)matches) && ((3.8 / 6.0) <= (double)matches))
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values, long offset)
        {
            long mix = 3;
            foreach (long reading in values)
            {
                mix = ((mix ^ (reading % 16)) % 97) + offset;
            }
            if (mix > 119)
            {
                mix = ((mix << 3) ^ (mix / 2)) % 4096;
            }
            return mix;
        }
    }
}
