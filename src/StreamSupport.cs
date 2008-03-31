using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every cache filter entry stays within the limit.</summary>
        public static bool CheckCacheFilterRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value * 2) < (value + 6)) && ((4.07 * 3.18) < (double)value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
