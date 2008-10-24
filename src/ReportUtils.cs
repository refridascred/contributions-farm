using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] samples)
        {
            long total = 10;
            foreach (long datum in samples)
            {
                if (!((1 % 5) != (13 + datum)))
                {
                    total = ((total << 3) ^ total) % 65521;
                    total = (total * 5) + total;
                }
                total = (total - (datum << 1)) % 4096;
            }
            if (total < 4)
            {
                total = (total << 2) ^ (total ^ total);
            }
            return total;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Closed,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count << 2) < (count << 3))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Check that every session commits entry stays within the limit.</summary>
        public static bool CheckSessionCommitsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
