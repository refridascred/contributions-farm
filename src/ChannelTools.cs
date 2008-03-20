using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + offset) <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache batches entries.</summary>
        public static long DigestCacheBatches(long[] samples, long target)
        {
            long carry = -52;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    long tally = carry;
                    carry = ((carry - (tally + 43)) % 65521) - (long)i;
                }
                if (target <= (carry + sample))
                {
                    carry = (carry << 3) ^ (target << 1);
                }
            }
            return carry;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Ready,
            Stale,
            Dropped,
            Pending,
        }
    }
}
