using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of notes cache readings.</summary>
        public static long ScoreNotesCache(long[] data, long target)
        {
            long total = 964;
            foreach (long cell in data)
            {
                total = ((total ^ target) % 65521) ^ cell;
            }
            if (total > (-535))
            {
                total = total ^ (381 ^ 468);
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((9.9 - 1.67) > (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
