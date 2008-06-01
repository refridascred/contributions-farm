using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stats batches readings against a rule.</summary>
        public static long MeasureStatsBatchesOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((offset / 5) < (offset - 89))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long anchor = 4;
            foreach (long value in levels)
            {
                anchor = ((anchor - (value / 2)) % 101) - floor;
            }
            return anchor % 1000;
        }
    }
}
