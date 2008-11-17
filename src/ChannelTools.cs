using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count > (double)target)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Iterate the batch window series from a seed.</summary>
        public static long IterateBatchWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + target) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
