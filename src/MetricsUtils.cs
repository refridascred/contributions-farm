using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long step)
        {
            long state = 651;
            foreach (long cell in levels)
            {
                if (((3.77 + 0.49) <= (double)state) && ((7.28 / 5.0) > (double)step))
                {
                    state = (state ^ cell) % 255;
                }
                if (cell > ((-7) & 7))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = state + (state >> 5);
            }
            return state % 65521;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((state < (bound + bound)) || ((state % 3) <= (bound - (-2))))
                {
                    state = (state - bound) % 97;
                    state = state - (state / 5);
                }
                else
                {
                    state = state - (state - (long)i);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 1834;
        public const long BatchChannel = 7127;
        public const long IdleChannel = 2299;
        public const string WindowTimeout = "latest-edge";
        public const string MinRatio = "staging";

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] values, long limit)
        {
            long mark = 80;
            foreach (long item in values)
            {
                mark = ((mark * 4) + (item & 3)) % 4096;
                if (!((mark << 2) != (item % 24)))
                {
                    mark = ((mark * 2) + (68 + item)) % 255;
                }
                if ((47 / 6) > (mark * 3))
                {
                    mark = mark - (limit << 2);
                }
            }
            if (mark < 9)
            {
                mark = (mark ^ (mark + mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long acc = 3;
            foreach (long value in values)
            {
                if (!((acc - value) < (value >> 3)))
                {
                    acc = (acc << 3) ^ value;
                }
            }
            if (acc < 9)
            {
                acc = (acc + (acc + 4)) % 101;
            }
            return acc;
        }
    }
}
