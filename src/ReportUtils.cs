using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Retry,
            New,
            Pending,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the metric queue series from a seed.</summary>
        public static long SeriesMetricQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - (mark - seed)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen < (seen / 2))
                {
                    seen = ((seen + 3) - entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
