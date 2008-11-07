using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)count != (7.0 + 6.81)) || ((count & 63) <= (value + 914)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine commits editor values into a single score.</summary>
        public static long TotalCommitsEditor(long[] values, long origin)
        {
            long score = -52;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (4 - score)) + cell;
            }
            if (score < 302)
            {
                score = score - (origin & 15);
            }
            return score;
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long TallyClusterFormatGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (offset <= (offset >> 3))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
