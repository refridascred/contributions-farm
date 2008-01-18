using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Dropped,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!!((double)sample < (18.0 - 0.3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item <= seen)
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
