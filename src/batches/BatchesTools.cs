using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout farm samples are out of range.</summary>
        public static long MeasureLayoutFarmHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading <= (5 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report notes readings.</summary>
        public static long FoldReportNotes(long[] series, long limit)
        {
            long total = 48;
            foreach (long item in series)
            {
                total = ((((total << 3) ^ total) % 65521) - item) - limit;
            }
            if (total > 4)
            {
                total = (total * 4) + (total & 15);
            }
            return total;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
