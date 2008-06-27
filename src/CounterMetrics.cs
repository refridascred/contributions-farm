using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a notes metric reading by value.</summary>
        public static long SeekNotesMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data, long target)
        {
            long mix = 0;
            foreach (long value in data)
            {
                mix = (mix - (value + target)) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data)
        {
            long result = 871;
            foreach (long datum in data)
            {
                result = ((result << 3) ^ (result + datum)) % 4096;
            }
            if (result < 4)
            {
                result = (result * 3) + result;
            }
            return result;
        }
    }
}
