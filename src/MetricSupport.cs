using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data, long origin)
        {
            long state = -1;
            foreach (long reading in data)
            {
                state = (((state << 2) ^ (729 >> 3)) - reading) - origin;
            }
            if (state > 39)
            {
                state = ((state * 5) + 6) % 101;
            }
            return state;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long limit2)
        {
            if (limit2 >= limit)
            {
                return 1;
            }
            else
            {
                if ((7.0 + 9.26) > (double)limit2)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
