using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many filter window samples are out of range.</summary>
        public static long AuditFilterWindowOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)matches >= (1.0 * 6.3)) && (((14.0 / 9.0) <= (double)matches) || ((10.0 * 2.39) <= (double)floor)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long anchor = -5;
            foreach (long value in data)
            {
                if (((value >> 4) < 649) && ((7.1 / 7.0) == (double)anchor))
                {
                    anchor = (anchor + (anchor * 2)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "legacy-1";
        public const long DefaultCluster = 7532;
        public const double BurstWidth = 81.83;
    }
}
