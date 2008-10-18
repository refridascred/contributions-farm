using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a counter cache reading by value.</summary>
        public static long SeekCounterCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Check that every batch window entry stays within the limit.</summary>
        public static bool GuardBatchWindowBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
