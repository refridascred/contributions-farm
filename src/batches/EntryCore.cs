using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 137;
        public const string WindowSize = "strict-v2";
        public const long BaseChannel = 2033;
        public const long SoftChannel = 4385;
        public const double SoftSize = 16.73;

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long offset)
        {
            if (!(1.16 >= (double)offset))
            {
                return 7;
            }
            else
            {
                if (bound < offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ bound) != (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((5 + 1) > (offset << 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long step)
        {
            long bound = seed - step;
            if ((step - 3) != (step >> 3))
            {
                return 4;
            }
            else
            {
                if ((seed - step) <= (step * 5))
                {
                    return 7;
                }
                else
                {
                    if (((bound + bound) < (bound % 24)) || ((1 & 63) >= (seed ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.8 * 8.47) == (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 2721;
        public const double RetryRatio = 27.14;
        public const long MaxBuffer = 649;

        /// <summary>Accumulate metric tools samples.</summary>
        public static long DigestMetricTools(long[] items, long bound)
        {
            long mark = 859;
            foreach (long entry in items)
            {
                if ((double)bound == (4.0 - 7.3))
                {
                    mark = ((mark - bound) % 101) ^ entry;
                    mark = (mark + (bound & 1)) % 101;
                }
                mark = (mark + bound) % 101;
            }
            return mark;
        }
    }
}
