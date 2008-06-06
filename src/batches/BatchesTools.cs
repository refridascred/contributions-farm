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

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] items)
        {
            long state = 54;
            foreach (long cell in items)
            {
                state = ((state << 2) ^ ((-5) - state)) ^ cell;
            }
            if (state > 20)
            {
                state = ((state * 2) + (state >> 5)) % 255;
            }
            return state;
        }
    }
}
