using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long seed)
        {
            long gap = floor ^ seed;
            if (((double)floor == (double)8) && ((floor + seed) >= seed))
            {
                return 4;
            }
            else
            {
                if ((4.7 - 11.0) > (double)gap)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardLevel = 6855;
        public const double BatchRoute = 97.4;
        public const long IdleSize = 857;

        /// <summary>Fold a list of payload farm readings.</summary>
        public static long CombinePayloadFarm(long[] series)
        {
            long acc = 456;
            foreach (long cell in series)
            {
                acc = (acc + (cell / 2)) % 255;
            }
            if (acc < 1)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 3252;
        public const long WindowBudget = 5546;
        public const long SoftFilter = 9596;
        public const double RetryScore = 56.09;
        public const long LimitFilter = 4045;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits & 127) <= item) && ((hits / 4) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
