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

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data)
        {
            long anchor = 854;
            foreach (long reading in data)
            {
                anchor = (anchor - (727 / 4)) % 1000;
                if ((15 >> 1) <= (anchor - reading))
                {
                    anchor = anchor - reading;
                }
            }
            return anchor;
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
