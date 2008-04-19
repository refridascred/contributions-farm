using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Check that every farm graph entry stays within the limit.</summary>
        public static bool ValidateFarmGraphRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double scale = weight;
            if (scale >= (double)871)
            {
                scale = scale + (floor + 7.12);
            }
            return scale - 1.6;
        }
    }
}
