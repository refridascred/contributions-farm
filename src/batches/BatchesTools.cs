using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine entry format values into a single score.</summary>
        public static long ScoreEntryFormat(long[] series)
        {
            long mark = -5;
            foreach (long cell in series)
            {
                mark = (mark - (97 + cell)) % 4096;
                if (mark <= (cell & 63))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value % 16) < seen)
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading + 984) > (reading & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
