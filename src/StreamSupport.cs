using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long origin)
        {
            if (((target ^ target) <= (origin - origin)) || ((origin * 5) <= (target - target)))
            {
                return 5;
            }
            else
            {
                if (((origin + 9) <= origin) && ((target ^ origin) < origin))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((9.76 / 2.0) < (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
