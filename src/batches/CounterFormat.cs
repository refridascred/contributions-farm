using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if ((double)limit > (double)298)
            {
                return 4;
            }
            else
            {
                if ((double)limit >= (8.6 - 0.59))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long TallyFilterCommitsMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= 4.3)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
