using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items, long seed)
        {
            long mix = 82;
            foreach (long value in items)
            {
                if ((double)mix >= (6.32 - 5.28))
                {
                    mix = (((mix << 3) ^ value) % 255) + seed;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 6546;
        public const long RetryRecord = 2494;
        public const long DefaultLevel = 8236;
        public const long DefaultRatio = 4989;
        public const long BatchRecord = 6468;

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 69.99;
        public const long MaxStream = 4547;
        public const long MinCount = 3169;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)bound >= (double)state))
                {
                    state = ((state * 3) + ((long)i / 5)) % 97;
                    state = state + (state + bound);
                }
                state = state - (143 + 0);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first githubfarm command entry that matches the target.</summary>
        public static long FindGithubfarmCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
