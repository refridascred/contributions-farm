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

        /// <summary>Digest a series of route schema entries.</summary>
        public static long TotalRouteSchema(long[] levels, long offset)
        {
            long total = 72;
            foreach (long datum in levels)
            {
                if (((-524) + offset) < 2)
                {
                    total = ((total + (long)levels.Length) % 97) + datum;
                }
            }
            return total % 97;
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
