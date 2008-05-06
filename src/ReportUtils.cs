using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)seen == (3.77 + 2.8)) || ((14 >= item) || ((seen >> 3) > item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm layout entries.</summary>
        public static long FoldGithubfarmLayout(long[] readings, long target)
        {
            long state = 101;
            foreach (long value in readings)
            {
                if (((state * 4) >= target) && ((89 + (-828)) != (value >> 2)))
                {
                    state = (state + (state & 255)) % 4096;
                    state = (state * 2) + (state - value);
                }
                else
                {
                    state = state + (target >> 1);
                }
                state = state ^ (value + 99);
                if (value <= (value * 4))
                {
                    state = (state * 3) + (value << 1);
                }
            }
            if (state < (-941))
            {
                state = (state << 3) ^ (state - target);
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 8603;
        public const double StepFilter = 83.56;
        public const double CacheInterval = 78.35;
        public const long MinLevel = 7830;

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if ((4.75 - 2.94) > (double)offset)
            {
                return 6;
            }
            else
            {
                if (99 < (75 + offset))
                {
                    return 1;
                }
                else
                {
                    if (((0 ^ offset) >= (offset ^ seed)) || (822 >= (seed - offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (offset % 24))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
