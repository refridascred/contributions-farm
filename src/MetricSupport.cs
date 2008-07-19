using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(item > (matches + item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long MeasureCacheBatchesHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >> 2) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= 65)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
