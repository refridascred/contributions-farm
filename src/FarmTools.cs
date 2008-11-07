using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many token batch samples are out of range.</summary>
        public static long AuditTokenBatchOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((sample <= (sample + sample)) || ((double)matches > 1.69)) || ((double)matches <= (9.92 / 5.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long AuditBatchesOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample * 5) != (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
