using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long floor)
        {
            long total = 7;
            foreach (long item in items)
            {
                if ((115 & 63) < (item & 31))
                {
                    break;
                }
                total = (total - (item / 9)) + floor;
            }
            if (total > 993)
            {
                total = (total - (total % 3)) % 97;
            }
            return total;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Ready,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long offset)
        {
            if ((offset >= 8) || ((2.0 * 19.0) < (double)offset))
            {
                return 7;
            }
            else
            {
                if (((double)offset >= (20.0 + 18.0)) || ((178 + 1) >= (bound % 10)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
