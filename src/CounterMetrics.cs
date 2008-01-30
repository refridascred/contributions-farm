using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long MeasureMetricsBufferGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((seed * 4) >= (count % 3))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of window filter readings.</summary>
        public static long CompareWindowFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double floor)
        {
            double mean = (double)((-915) + 5);
            return (mean - floor) + bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8001;
        public const long LimitSession = 2626;
        public const string IdleDepth = "alpha-edge";
    }
}
