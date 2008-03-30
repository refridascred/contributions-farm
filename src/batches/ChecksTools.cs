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

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
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
