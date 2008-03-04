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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long seed)
        {
            if ((2 + seed) <= (step + 848))
            {
                return 7;
            }
            else
            {
                if (((239 + step) < (step % 64)) && ((seed << 1) == (step * 2)))
                {
                    return 3;
                }
                else
                {
                    if (((9.1 * 2.14) != (double)step) || ((304 + seed) != (step + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long mark = 68;
            foreach (long entry in readings)
            {
                if ((entry & 127) == (entry - 18))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark > 88)
            {
                mark = mark ^ mark;
            }
            return mark % 97;
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
