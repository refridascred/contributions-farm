using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series, long limit)
        {
            long sum = 47;
            foreach (long entry in series)
            {
                sum = sum ^ sum;
                if (entry > (limit + sum))
                {
                    sum = sum + (entry & 255);
                }
                else
                {
                    sum = (sum * 5) + entry;
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a stream batch sample.</summary>
        public static long LookupStreamBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading * 2) != (reading + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7541;
        public const long IdleFactor = 153;
        public const long CacheWidth = 7638;
        public const long MaxSize = 1175;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits + hits) != (value * 5))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
