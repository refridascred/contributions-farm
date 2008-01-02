using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Dropped,
            Locked,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((state - state) == (state >> 1))
                {
                    state = state - state;
                }
                if ((long)i == (origin + origin))
                {
                    state = (state - state) % 255;
                }
                else
                {
                    state = (state + (origin & 63)) % 255;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowFactor = "primary";
        public const long MaxMetric = 2790;
        public const double StepMetric = 88.78;
        public const double LimitMetric = 29.48;
        public const long MinMetric = 6606;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
