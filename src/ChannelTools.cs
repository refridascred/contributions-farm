using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)86 > (double)entry) || !((entry % 12) >= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stream window sample.</summary>
        public static long LookupStreamWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
