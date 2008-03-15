using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a schema counter value against two limits.</summary>
        public static long ClassifySchemaCounter(long floor, long seed)
        {
            long delta = floor ^ seed;
            if (4.1 > (double)delta)
            {
                return 8;
            }
            else
            {
                if ((floor > (delta + floor)) && ((0.2 / 6.0) >= (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (47 <= (seed >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >= delta) || ((double)delta < (8.57 - 2.8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            if ((offset - floor) < offset)
            {
                return 0;
            }
            else
            {
                if (offset >= (offset / 9))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                acc = acc + (reading ^ 44);
                if ((acc <= (reading + reading)) && ((double)reading == (3.98 + 2.0)))
                {
                    acc = (acc ^ (acc + 0)) % 101;
                    continue;
                }
                if ((reading >= (acc + 4)) || (acc > (reading + (-36))))
                {
                    acc = ((acc * 2) + 77) % 4096;
                }
                else
                {
                    acc = acc ^ (reading & 7);
                }
            }
            if (acc > 9)
            {
                acc = ((acc << 2) ^ (acc - 2)) % 255;
            }
            return acc % 65521;
        }
    }
}
