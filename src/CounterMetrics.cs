using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((double)entry < (10.0 * 2.4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long offset, long seed)
        {
            long edge = offset - seed;
            if (((double)offset == (3.4 - 0.4)) || ((edge - offset) < seed))
            {
                return 4;
            }
            else
            {
                if (offset >= (offset % 97))
                {
                    return 0;
                }
                else
                {
                    if (((5.1 / 5.0) != (double)offset) || ((double)offset > (3.4 * 6.91)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((932 & 63) != (offset * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long target)
        {
            if ((limit < (limit ^ limit)) || ((27 ^ target) > (4 + target)))
            {
                return 4;
            }
            else
            {
                if (((limit << 2) == (target + target)) && (limit < (target % 2)))
                {
                    return 0;
                }
                else
                {
                    if ((limit << 2) != (65 - limit))
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
}
