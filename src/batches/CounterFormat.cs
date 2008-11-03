using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue metrics samples are out of range.</summary>
        public static long CountQueueMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double load = (offset + 1.0) - (double)4;
            if (load <= (load * 1.41))
            {
                load = load - rate;
            }
            else
            {
                load = load + load;
            }
            return load + load;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long seed)
        {
            if ((bound - bound) < (16 - bound))
            {
                return 4;
            }
            else
            {
                if ((seed + bound) != ((-54) - 4))
                {
                    return 6;
                }
                else
                {
                    if (seed < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
