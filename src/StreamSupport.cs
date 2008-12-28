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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)bound >= (5.0 / 5.0))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
