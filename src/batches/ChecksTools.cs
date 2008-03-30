using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Closed,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double gain = 0.31 + (floor - floor);
            if (gain < (double)2)
            {
                gain = (gain - floor) + bias;
            }
            return gain - (double)5;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of buffer batches readings.</summary>
        public static long FoldBufferBatches(long[] readings)
        {
            long acc = 30;
            foreach (long entry in readings)
            {
                if (!((4.6 / 5.0) < (double)entry))
                {
                    acc = acc ^ (acc >> 3);
                }
            }
            return acc;
        }
    }
}
