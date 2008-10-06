using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Locked,
            Stale,
            New,
            Draft,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long target)
        {
            if ((target / 5) >= (offset - offset))
            {
                return 4;
            }
            else
            {
                if (((offset + offset) <= offset) || ((target % 3) <= (offset % 12)))
                {
                    return 2;
                }
                else
                {
                    if ((target + target) >= (offset + 940))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
