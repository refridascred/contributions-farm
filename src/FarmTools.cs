using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of support format entries.</summary>
        public static long TotalSupportFormat(long[] levels, long offset)
        {
            long anchor = -130;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ (anchor << 3)) + reading) + offset;
            }
            return anchor % 4096;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long sum = 869;
            foreach (long cell in data)
            {
                sum = sum ^ (cell * 4);
            }
            return sum % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + hits) >= hits)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
