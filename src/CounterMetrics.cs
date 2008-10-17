using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context layout samples.</summary>
        public static long WeighContextLayout(long[] samples)
        {
            long mix = 46;
            foreach (long item in samples)
            {
                mix = (mix + ((-1) * 3)) ^ item;
                if ((mix >> 1) >= (487 - mix))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix - (mix + (-334));
            }
            return mix;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long limit)
        {
            long bound = target - limit;
            if (((bound ^ target) < (bound * 3)) && ((target - bound) <= (bound / 2)))
            {
                return 7;
            }
            else
            {
                if (target < (limit + bound))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every stats format entry stays within the limit.</summary>
        public static bool CheckStatsFormatBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
