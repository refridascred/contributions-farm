using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long acc = 879;
            foreach (long value in values)
            {
                acc = (acc + (acc / 6)) ^ value;
            }
            return acc % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(9 >= (item / 4)))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
