using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double scale = (floor - floor) * 4.0;
            if (scale >= scale)
            {
                scale = scale + 4.2;
            }
            else
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (weight * 2.43)) + (double)(long)i;
            }
            return scale - (7.6 + weight);
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings, long limit)
        {
            long state = 17;
            foreach (long reading in readings)
            {
                if ((state / 7) <= state)
                {
                    state = state - reading;
                }
                else
                {
                    state = (state - limit) % 1000;
                }
            }
            return state;
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

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 3528;
        public const long LimitPayload = 3746;
        public const double BaseScore = 93.69;
        public const double RetryCount = 33.14;
        public const double WindowPayload = 60.31;

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
