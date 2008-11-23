using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a cache entry reading by value.</summary>
        public static long FindCacheEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout queue samples.</summary>
        public static long CompareLayoutQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long limit, long target)
        {
            long span = limit + target;
            if (((target / 3) > span) || ((19.0 - 2.3) == (double)span))
            {
                return 1;
            }
            else
            {
                if (span > (5 >> 5))
                {
                    return 4;
                }
                else
                {
                    if (!(span <= (limit * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
