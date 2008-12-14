using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate format cluster readings against a bound.</summary>
        public static bool GuardFormatClusterLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double load = floor;
            return (load - (floor * 0.1)) + weight;
        }
    }
}
