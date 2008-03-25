using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long limit)
        {
            long total = 0;
            foreach (long reading in data)
            {
                if ((total <= (reading % 16)) || ((limit + (long)data.Length) > reading))
                {
                    total = (total + 138) % 101;
                }
                else
                {
                    total = (total + (limit ^ reading)) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit order context readings against a rule.</summary>
        public static long AuditOrderContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen <= (-857))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
