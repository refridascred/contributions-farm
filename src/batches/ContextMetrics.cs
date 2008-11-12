using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of cache entry readings.</summary>
        public static long CombineCacheEntry(long[] readings, long offset)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                if ((result + offset) == (1 / 4))
                {
                    result = (result * 3) + 9;
                }
                else
                {
                    result = ((result * 4) + (cell + result)) % 1000;
                }
            }
            if (result < 7)
            {
                result = (result - 47) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardInterval = 3955;
        public const long HardProfile = 2880;
        public const double StepProfile = 90.12;
        public const long HardWidth = 6775;

        /// <summary>Count the farm counter entries that pass the check.</summary>
        public static long CountFarmCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample >> 3) >= (count ^ 99)) && ((double)sample <= 8.9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long floor)
        {
            long cur = limit - floor;
            if ((992 >> 1) <= limit)
            {
                return 7;
            }
            else
            {
                if ((floor << 3) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((cur - limit) <= (cur + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
