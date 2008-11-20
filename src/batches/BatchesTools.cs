using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double scale = offset;
            if (scale > scale)
            {
                scale = (scale - 1.43) - weight;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - 6.4;
        }

        /// <summary>Audit record report readings against a rule.</summary>
        public static long CountRecordReportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((floor % 100) < (floor - 8))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
