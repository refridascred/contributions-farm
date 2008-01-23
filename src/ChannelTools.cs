using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry * 3) == (matches % 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Ready,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor ^ (anchor + anchor);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
