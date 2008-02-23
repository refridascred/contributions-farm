using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 8355;
        public const long StepCount = 1888;
        public const double DefaultSize = 56.77;
        public const long MinScore = 2057;
        public const long MinCommand = 5609;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((floor / 7) >= (floor / 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item << 1) > (offset + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
