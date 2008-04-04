using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Dropped,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = total ^ (floor + (long)i);
                total = (total << 2) ^ (floor % 5);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total * 2) + (total + floor)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
