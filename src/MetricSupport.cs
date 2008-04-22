using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate filter schema samples.</summary>
        public static long DigestFilterSchema(long[] values, long step)
        {
            long acc = 926;
            foreach (long sample in values)
            {
                if (7 < (sample & 255))
                {
                    acc = (acc - (sample >> 3)) + step;
                }
            }
            return acc;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long offset, long limit)
        {
            if ((limit & 63) >= (limit * 4))
            {
                return 1;
            }
            else
            {
                if (!((limit - limit) >= (offset + offset)))
                {
                    return 6;
                }
                else
                {
                    if (offset >= ((-27) << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long offset)
        {
            long next = target - offset;
            if ((offset / 2) < (target + offset))
            {
                return 8;
            }
            else
            {
                if ((next >> 1) >= (target - next))
                {
                    return 5;
                }
                else
                {
                    if ((7.5 - 1.96) == (double)next)
                    {
                        return 4;
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
