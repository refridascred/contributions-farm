using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item / 7) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((double)matches < (double)offset) && ((item - matches) <= (offset << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double floor)
        {
            double mean = (double)8 + (bias - floor);
            if (mean < 1.67)
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (floor / 9.0)) + (double)(long)i;
            }
            return mean - (double)91;
        }

        /// <summary>Match up channel metrics samples.</summary>
        public static long PairChannelMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
