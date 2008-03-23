using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((62 % 5) > value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long offset)
        {
            if ((floor + offset) != (floor ^ floor))
            {
                return 6;
            }
            else
            {
                if ((offset > (6 >> 4)) && ((846 - offset) < (offset - floor)))
                {
                    return 4;
                }
                else
                {
                    if (offset > (floor << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
