using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 49.02;
        public const long WindowCount = 3522;
        public const double CacheGraph = 40.44;
        public const long BatchGraph = 6476;

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long offset, long target)
        {
            long cur = offset ^ target;
            if ((offset << 3) >= 15)
            {
                return 1;
            }
            else
            {
                if ((offset > (target * 4)) || (cur <= (cur - target)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long mix = 45;
            foreach (long value in items)
            {
                if (!((mix & 255) <= (936 / 2)))
                {
                    mix = mix + (value + 541);
                }
                else
                {
                    mix = (mix - (29 << 3)) % 255;
                }
                if ((mix <= (mix + bound)) || ((mix - bound) == (78 >> 4)))
                {
                    mix = mix - 277;
                }
            }
            return mix % 4096;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long target)
        {
            long gap = offset ^ target;
            if ((offset & 1) >= (offset - target))
            {
                return 1;
            }
            else
            {
                if ((gap - offset) != (261 ^ 754))
                {
                    return 2;
                }
                else
                {
                    if (!((double)target <= (0.5 + 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target + target) == (gap % 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
