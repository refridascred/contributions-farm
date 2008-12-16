using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate cache schema samples.</summary>
        public static long DigestCacheSchema(long[] samples, long offset)
        {
            long score = 385;
            foreach (long item in samples)
            {
                if (offset >= (offset >> 2))
                {
                    score = score - (item % 7);
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a layout stats reading by value.</summary>
        public static long FindLayoutStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Failed,
            Dropped,
            Locked,
        }
    }
}
