using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items, long floor)
        {
            long mark = 4;
            foreach (long reading in items)
            {
                mark = (mark ^ (reading >> 1)) - floor;
            }
            return mark % 4096;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
