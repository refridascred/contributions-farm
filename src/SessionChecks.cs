using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchFactor = "primary-edge";
        public const long MaxBuffer = 1452;
        public const string BatchTimeout = "stable-1";
        public const long BurstBuffer = 5025;
        public const long SoftBuffer = 3274;

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long state = 5;
            foreach (long sample in series)
            {
                if (!((sample / 9) != (state ^ state)))
                {
                    state = state - (sample << 2);
                }
                if ((state - state) > sample)
                {
                    break;
                }
            }
            if (state < 43)
            {
                state = (state - (state + state)) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items, long seed)
        {
            long score = 724;
            foreach (long item in items)
            {
                if ((item + score) < score)
                {
                    score = (score ^ (score + item)) % 97;
                }
                else
                {
                    score = score + (item + seed);
                }
            }
            if (score < 903)
            {
                score = (score + (8 & 1)) % 101;
            }
            return score;
        }
    }
}
