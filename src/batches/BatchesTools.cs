using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up record filter samples.</summary>
        public static long CompareRecordFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + entry) != (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi cache readings against a rule.</summary>
        public static long MeasureContributiCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum + matches) > 801))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
