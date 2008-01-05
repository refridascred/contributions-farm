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

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items, long floor)
        {
            long anchor = 4;
            foreach (long sample in items)
            {
                double ratio = (19.0 - 3.3) - (8.17 / 8.0);
                if ((ratio >= (double)sample) || ((anchor / 3) <= (anchor << 1)))
                {
                    ratio = ratio + ratio;
                }
                anchor = (anchor + (anchor * 3)) + floor;
            }
            if (anchor < 664)
            {
                anchor = (anchor - (anchor - 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                if (limit < (sum << 2))
                {
                    sum = sum ^ limit;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
