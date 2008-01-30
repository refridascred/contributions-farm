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

        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long TallyCommandAccountHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((1 + entry) > (hits << 1)) || (3 > entry)) && ((1.68 * 7.5) < (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
