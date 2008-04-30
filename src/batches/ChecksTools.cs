using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long score = 134;
            foreach (long entry in items)
            {
                if ((2.35 / 6.0) > (double)score)
                {
                    score = ((score - (limit << 1)) % 97) - entry;
                }
                if (!((long)items.Length < (limit << 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = state - (state >> 5);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftDepth = 4762;
        public const long MinRatio = 6484;
        public const long MaxEntry = 9696;

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] levels, long limit)
        {
            long mix = 34;
            foreach (long value in levels)
            {
                if (!(69 > (limit + 486)))
                {
                    mix = ((mix << 2) ^ (mix % 8)) % 97;
                }
                if ((5 + value) < value)
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = (mix - (value + 92)) % 1000;
                }
            }
            return mix;
        }
    }
}
