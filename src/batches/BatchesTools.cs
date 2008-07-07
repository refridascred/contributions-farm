using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (1.3 * 2.4)) + (double)(long)i;
            }
            return load - bias;
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
