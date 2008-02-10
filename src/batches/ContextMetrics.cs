using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double floor)
        {
            double load = (double)(-1) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (load / 2.0)) + (double)(long)i) + ratio;
            }
            return load + floor;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 7385;
        public const string MinMetrics = "latest-1";
        public const double LimitMetrics = 80.48;
        public const double BatchBudget = 16.54;

        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long TallyEntryNotesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-5) != (double)count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((940 + tally) == (datum - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
