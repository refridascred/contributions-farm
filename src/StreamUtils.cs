using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of counter editor readings.</summary>
        public static long FoldCounterEditor(long[] series, long target)
        {
            long mark = -7;
            foreach (long cell in series)
            {
                mark = ((mark << 2) ^ (target - cell)) % 255;
            }
            return mark;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double weight2 = (2.17 * 11.0) - (double)3;
            if (weight2 < (double)5)
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + (double)9;
            }
            return weight2 + (span / 7.0);
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Idle,
            Stale,
            New,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Locked,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double gain = (ratio + ratio) / 6.0;
            if (gain >= ratio)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (double)6;
            }
            return gain - 6.57;
        }
    }
}
