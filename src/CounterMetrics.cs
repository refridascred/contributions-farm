using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of editor counter readings.</summary>
        public static long MatchEditorCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Active,
            Closed,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < floor)
            {
                mean = mean + (mean + ratio);
            }
            return mean - (ratio / 8.0);
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)seed != (7.0 * 6.07))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
