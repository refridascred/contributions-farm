using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchScore = 1768;
        public const string WindowDepth = "stable-v2";
        public const long WindowSize = 7325;
        public const long BatchBatches = 4978;

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                mark = ((mark + mark) % 1000) - value;
            }
            if (mark < 722)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long RankContextGithubfarm(long origin, long floor)
        {
            if (((7.77 + 4.4) == (double)origin) && ((origin & 3) != (floor % 24)))
            {
                return 4;
            }
            else
            {
                if ((floor & 3) < (origin - floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((39 & 127) <= (origin * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
