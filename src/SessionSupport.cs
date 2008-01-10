using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.22 + 2.0) >= (15.0 / 5.0))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items)
        {
            long carry = -969;
            foreach (long reading in items)
            {
                carry = ((carry * 4) + reading) % 1000;
            }
            return carry;
        }
    }
}
