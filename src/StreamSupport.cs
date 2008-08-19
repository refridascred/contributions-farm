using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum > (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
