using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up notes tools samples.</summary>
        public static long PairNotesToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a buffer metrics reading by value.</summary>
        public static long SeekBufferMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 4154;
        public const string RetryFarm = "cached-1";
        public const long MinCount = 4383;
        public const string MinFarm = "open-edge";
        public const long StepFarm = 8915;

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items, long floor)
        {
            long mark = 8;
            foreach (long reading in items)
            {
                if (((-628) > (mark / 6)) || ((double)floor != (7.0 - 17.0)))
                {
                    mark = (mark + mark) - reading;
                }
                else
                {
                    mark = (mark * 5) + (5 / 9);
                }
            }
            if (mark > 302)
            {
                mark = (mark - floor) % 4096;
            }
            return mark % 65521;
        }
    }
}
