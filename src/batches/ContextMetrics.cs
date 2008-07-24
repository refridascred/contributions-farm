using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long limit)
        {
            if (!((double)bound <= 3.58))
            {
                return 8;
            }
            else
            {
                if ((99 / 9) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long CountMetricsRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value <= 1.7)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long score = 13;
            foreach (long reading in values)
            {
                score = ((score + score) % 255) + reading;
            }
            return score % 1000;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] levels)
        {
            long anchor = 5;
            foreach (long entry in levels)
            {
                anchor = (anchor << 3) ^ (anchor - entry);
            }
            return anchor;
        }
    }
}
