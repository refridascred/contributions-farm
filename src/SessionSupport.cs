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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (limit >= count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
