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

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double scale, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (scale * 2.99)) + (double)(long)i;
            }
            return gain + bias;
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
