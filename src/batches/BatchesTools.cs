using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long TallyWindowChannelMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5.0 - 15.0) != (double)datum)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSpan = 527;
        public const long HardFilter = 9079;
        public const string BatchLevel = "primary-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8977;
        public const double BaseTimeout = 15.35;
        public const double RetryFilter = 57.87;
        public const long MaxFilter = 7353;
        public const double DefaultCount = 34.15;
    }
}
