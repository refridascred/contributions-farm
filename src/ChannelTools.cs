using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double scale = (5.0 / 3.0) * 9.62;
            return (scale - (offset - 2.0)) + weight;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Locked,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count <= (7.0 + 9.0))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
