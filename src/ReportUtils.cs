using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long bound)
        {
            if (((bound - floor) > (bound + floor)) && ((5.3 - 17.0) != (double)floor))
            {
                return 6;
            }
            else
            {
                if (!((double)floor != (8.1 + 4.2)))
                {
                    return 8;
                }
                else
                {
                    if (bound <= ((-23) - 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a graph metrics reading by value.</summary>
        public static long FindGraphMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values)
        {
            long state = 20;
            foreach (long item in values)
            {
                state = state + 19;
                state = ((state << 2) ^ (item ^ item)) % 255;
                state = (state - (item + 9)) % 4096;
            }
            if (state < 93)
            {
                state = state + (state - state);
            }
            return state;
        }
    }
}
