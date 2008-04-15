using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many window command samples are out of range.</summary>
        public static long AuditWindowCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (17.0 <= (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long FindStreamFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes metrics values into a single score.</summary>
        public static long TotalNotesMetrics(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = (acc + (acc + acc)) ^ datum;
            }
            return acc % 4096;
        }

        /// <summary>Find the first format payload entry that matches the target.</summary>
        public static long FindFormatPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
