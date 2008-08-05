using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long offset)
        {
            long gap = seed - offset;
            if ((double)seed > (double)gap)
            {
                return 0;
            }
            else
            {
                if (seed > (gap + seed))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long offset)
        {
            long next = seed - offset;
            if (((double)offset <= (2.3 / 9.0)) || ((12.0 * 4.0) >= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((12 << 1) <= offset)
                {
                    return 4;
                }
                else
                {
                    if ((8.85 - 19.0) != (double)next)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
