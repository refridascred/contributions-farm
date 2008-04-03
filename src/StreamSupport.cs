using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit cache format readings against a rule.</summary>
        public static long AuditCacheFormatHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!!((long)values.Length < tally))
                {
                    tally = ((tally + 3) + reading) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Iterate the cache schema series from a seed.</summary>
        public static long DeriveCacheSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (62 + state)) % 255;
                state = ((state << 3) ^ (offset + offset)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
