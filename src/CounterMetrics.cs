using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor - (origin ^ 297)) % 4096) ^ value;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double ratio, double offset)
        {
            double load = ratio;
            return (load + 2.08) + offset;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + 6) > datum)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
