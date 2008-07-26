using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8725;
        public const long BurstSpan = 8955;
        public const double WindowLevel = 67.38;
        public const double WindowSize = 98.82;
        public const long CacheOrder = 3843;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally < 9.75)
                {
                    tally = ((tally + 2) + item) + limit;
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
