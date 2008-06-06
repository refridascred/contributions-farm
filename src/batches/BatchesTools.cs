using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long step)
        {
            if (((double)offset > (9.82 - 9.06)) || ((offset % 97) < (step - offset)))
            {
                return 3;
            }
            else
            {
                if (((91 + step) > 792) || (step >= (step + (-987))))
                {
                    return 4;
                }
                else
                {
                    if (step > (step + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long WeighContextWindow(long[] items)
        {
            long anchor = 868;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ (anchor % 12)) + item;
            }
            if (anchor < 235)
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
            }
            return anchor;
        }
    }
}
