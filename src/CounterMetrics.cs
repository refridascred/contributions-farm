using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate context record samples.</summary>
        public static long FoldContextRecord(long[] series, long step)
        {
            long mark = 4;
            foreach (long reading in series)
            {
                if (mark >= (step >> 5))
                {
                    mark = mark - ((-5) + reading);
                }
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 176;
        public const double WindowSpan = 86.25;
        public const string MinScore = "legacy";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long floor, long seed)
        {
            if ((floor <= (floor / 4)) && ((floor - 125) < (floor & 63)))
            {
                return 1;
            }
            else
            {
                if (((seed * 3) != (seed % 10)) || ((floor + floor) != (seed + 92)))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 3) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
