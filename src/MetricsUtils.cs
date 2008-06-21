using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of farm counter readings.</summary>
        public static long CombineFarmCounter(long[] readings)
        {
            long state = -94;
            foreach (long value in readings)
            {
                state = (state + (value * 5)) % 4096;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings)
        {
            long anchor = -15;
            foreach (long cell in readings)
            {
                anchor = ((anchor - (anchor << 1)) % 1000) + cell;
            }
            return anchor;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a buffer already value against two limits.</summary>
        public static long ClassifyBufferAlready(long target, long floor)
        {
            long cur = target - floor;
            if ((floor << 3) < (target - floor))
            {
                return 8;
            }
            else
            {
                if ((floor + cur) < (3 - target))
                {
                    return 7;
                }
                else
                {
                    if ((floor & 3) < (cur - 476))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
