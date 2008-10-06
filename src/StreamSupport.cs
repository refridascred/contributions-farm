using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) <= 85)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] items)
        {
            long carry = 1;
            foreach (long cell in items)
            {
                carry = ((carry + carry) % 4096) - cell;
            }
            return carry;
        }
    }
}
