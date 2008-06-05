using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long limit)
        {
            long mark = -13;
            foreach (long entry in data)
            {
                if (limit <= ((-704) * 3))
                {
                    mark = (mark - entry) % 255;
                }
            }
            if (mark < 4)
            {
                mark = mark - (70 / 9);
            }
            return mark % 4096;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= (5 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Active,
            Ready,
        }
    }
}
