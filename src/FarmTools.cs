using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] values)
        {
            long acc = 90;
            foreach (long cell in values)
            {
                acc = (((acc * 2) + (acc & 3)) % 4096) ^ cell;
            }
            if (acc > 9)
            {
                acc = acc + (acc & 255);
            }
            return acc % 97;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((64 - entry) >= (entry / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
