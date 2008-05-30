using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long seed)
        {
            long bound = target + seed;
            if ((double)seed > (5.56 * 15.0))
            {
                return 2;
            }
            else
            {
                if (((8.84 - 9.22) > (double)bound) && ((96 ^ target) >= bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + seed) == (seed - target)) || ((target + seed) <= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Paused,
            Queued,
        }
    }
}
