using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits support value against two limits.</summary>
        public static long GradeCommitsSupport(long floor, long target)
        {
            long gap = floor ^ target;
            if (floor <= (target - 3))
            {
                return 2;
            }
            else
            {
                if ((floor - 71) >= (target & 255))
                {
                    return 3;
                }
                else
                {
                    if (((floor - gap) <= floor) || ((0.35 + 1.6) <= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)gap == (2.0 + 12.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long seed)
        {
            long edge = floor - seed;
            if ((edge + seed) != (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((92 - floor) >= edge)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
