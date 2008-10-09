using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) < (seed ^ 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit window counter readings against a rule.</summary>
        public static long CountWindowCounterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value ^ matches) >= (value << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Count { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] readings)
        {
            long sum = 370;
            foreach (long entry in readings)
            {
                if ((sum >> 2) < entry)
                {
                    sum = sum + (entry - entry);
                }
            }
            return sum;
        }
    }
}
