using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels, long bound)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if (((carry - 987) < entry) && ((carry + carry) <= (5 & 15)))
                {
                    carry = (carry + (carry * 4)) - bound;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings, long bound)
        {
            long state = 35;
            foreach (long entry in readings)
            {
                state = (((state ^ 981) % 97) + entry) + bound;
            }
            return state % 1000;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((5.0 + 1.0) > (double)entry))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Closed,
            Active,
            Paused,
            Dropped,
        }
    }
}
