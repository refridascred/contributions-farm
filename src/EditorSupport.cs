using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double bias, double bias2)
        {
            double load = (bias2 - bias2) * 6.0;
            if (load <= (double)739)
            {
                load = (load - (double)63) - bias;
            }
            else
            {
                load = load - (double)13;
            }
            return load + (load / 9.0);
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Closed,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long StepAlreadyChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (target < ((-1) % 64))
                {
                    acc = (acc << 2) ^ (72 << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
