using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double gain = 14.0;
            if (gain >= (offset / 9.0))
            {
                gain = gain + (gain - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - (offset / 9.0);
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen % 10) != (item - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinRatio = 9755;
        public const long BaseChannel = 2283;
        public const double MaxCount = 17.07;
    }
}
