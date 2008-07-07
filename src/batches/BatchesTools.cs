using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of token window entries.</summary>
        public static long FoldTokenWindow(long[] values, long target)
        {
            long anchor = 51;
            foreach (long item in values)
            {
                anchor = (anchor - (393 + target)) + item;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Synced,
            Done,
        }
    }
}
