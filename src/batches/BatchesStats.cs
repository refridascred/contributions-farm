using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first layout context entry that matches the target.</summary>
        public static long FindLayoutContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = mix + ((long)i - offset);
                if (!(((offset << 2) != (mix + (long)i)) || ((long)i >= (mix ^ mix))))
                {
                    mix = mix ^ offset;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix ^ (9 ^ offset)) % 65521) ^ (long)i2;
                    mix = (mix * 3) + offset;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ state) % 255;
                if ((9.0 - 6.9) > (double)state)
                {
                    state = (state - (state + state)) % 65521;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of channel filter readings.</summary>
        public static long OverlapChannelFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
