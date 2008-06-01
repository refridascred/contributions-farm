using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (7.0 > (double)matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((29 % 8) == ((long)readings.Length & 3))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
