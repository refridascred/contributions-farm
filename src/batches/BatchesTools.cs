using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const long BatchStats = 1849;
        public const long LimitStats = 7904;
        public const string IdleStats = "fallback-1";

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Locked,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                if (((-1) >> 3) < (reading - anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                if (((double)96 >= (double)reading) && ((anchor ^ anchor) >= (reading % 10)))
                {
                    anchor = anchor ^ (85 * 5);
                }
            }
            if (anchor > 96)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor;
        }
    }
}
