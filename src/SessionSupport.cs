using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (double)2)
            {
                scale2 = (scale2 + (scale * 7.0)) + floor;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + scale;
        }
    }
}
