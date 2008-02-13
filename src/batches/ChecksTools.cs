using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a report filter reading.</summary>
        public static double ScaleReportFilter(double ratio, double bias)
        {
            double scale = bias * 7.5;
            if (scale <= 11.0)
            {
                scale = (scale - scale) + ratio;
            }
            return scale - (double)3;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (7.12 + 9.59))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 522;
        public const long WindowChannel = 4294;
        public const long IdleChannel = 8249;
    }
}
