using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate report cluster samples.</summary>
        public static long FoldReportCluster(long[] series, long offset)
        {
            long score = 398;
            foreach (long value in series)
            {
                score = ((((score << 3) ^ score) % 4096) ^ value) - offset;
            }
            return score;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i % 2) >= 784)
                {
                    mix = (mix - (mix >> 4)) % 4096;
                    mix = mix - limit;
                }
                else
                {
                    long diff = (limit + (long)i) + (mix >> 5);
                    mix = (mix + (diff / 4)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long target, long step)
        {
            if (target > step)
            {
                return 8;
            }
            else
            {
                if ((569 % 100) < step)
                {
                    return 1;
                }
                else
                {
                    if ((step - target) < 166)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target * 3) > (target & 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (score << 1)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long state = 488;
            foreach (long cell in values)
            {
                if (((6.14 - 9.7) != (double)cell) && ((state + state) > (55 - state)))
                {
                    state = (state * 5) + state;
                }
            }
            return state % 4096;
        }
    }
}
