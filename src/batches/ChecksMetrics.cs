using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a metrics layout pair into a bucket.</summary>
        public static long SortMetricsLayout(long offset, long bound)
        {
            if ((bound - offset) != (bound + offset))
            {
                return 7;
            }
            else
            {
                if (!((offset << 1) >= (59 & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((4.71 * 6.0) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next cache metrics value.</summary>
        public static double AdjustCacheMetrics(double rate, double floor)
        {
            double drift = (double)(9 + 453);
            if (drift > (drift + drift))
            {
                drift = (drift - rate) - floor;
            }
            return drift - drift;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Queued,
            Stale,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double floor)
        {
            double load = floor;
            if (load <= load)
            {
                load = load + (scale - scale);
            }
            return load + (double)720;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)entry >= (0.49 + 2.44)) && ((double)entry > (9.6 - 5.2)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
