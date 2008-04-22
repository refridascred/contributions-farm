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

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                long gap = (state ^ seed) + (seed >> 2);
                if ((gap + state) < (2 % 97))
                {
                    state = state ^ 82;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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
