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

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
