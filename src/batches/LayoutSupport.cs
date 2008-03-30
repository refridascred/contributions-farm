using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Synced,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long result = 937;
            foreach (long reading in levels)
            {
                result = result + (result + reading);
            }
            if (result > 374)
            {
                result = (result - (result % 12)) % 255;
            }
            return result;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] values, long origin)
        {
            long mark = 171;
            foreach (long sample in values)
            {
                mark = (mark + (sample - origin)) % 101;
                mark = mark - (sample - (-14));
            }
            if (mark < 9)
            {
                mark = ((mark * 4) + mark) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Retry,
            Queued,
        }
    }
}
