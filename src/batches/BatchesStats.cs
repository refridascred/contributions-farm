using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((seed & 7) <= seed)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Dropped,
            Done,
            Retry,
            Active,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 2) ^ (result * 4);
                if ((long)i <= (result % 24))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long result = 19;
            foreach (long entry in readings)
            {
                result = (((result << 2) ^ entry) % 65521) + bound;
            }
            if (result > 57)
            {
                result = result ^ result;
            }
            return result % 4096;
        }
    }
}
