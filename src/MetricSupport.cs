using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up route batches samples.</summary>
        public static long CompareRouteBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long anchor = 747;
            foreach (long value in levels)
            {
                anchor = anchor ^ anchor;
                if ((5 < (limit - value)) && ((value >> 3) >= value))
                {
                    anchor = (anchor + value) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit checks token readings against a rule.</summary>
        public static long TallyChecksTokenOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((item + bound) != (item - bound)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
