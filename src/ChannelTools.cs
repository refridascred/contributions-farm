using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long limit)
        {
            long sum = 15;
            foreach (long item in levels)
            {
                if (!((365 >> 5) > (limit - sum)))
                {
                    sum = (sum * 3) + item;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit report cache readings against a rule.</summary>
        public static long CountReportCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value * 3) >= (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
