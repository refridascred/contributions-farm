using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long floor, long seed)
        {
            long prev = floor ^ seed;
            if ((prev + seed) < 43)
            {
                return 3;
            }
            else
            {
                if ((9.0 <= (double)floor) || ((double)floor == (6.5 - 15.0)))
                {
                    return 1;
                }
                else
                {
                    if ((floor << 1) < (57 & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev + floor) >= 9)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
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
