using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long origin)
        {
            long state = -5;
            foreach (long datum in values)
            {
                if ((origin * 3) <= (datum + state))
                {
                    state = ((state * 2) + (datum << 3)) % 65521;
                }
                if ((double)origin < (double)state)
                {
                    state = (state * 5) + (state - 7);
                }
                else
                {
                    state = (state ^ (origin & 31)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double mean = (double)584 - (double)66;
            if (mean >= (double)238)
            {
                mean = mean + (rate + rate);
            }
            else
            {
                mean = mean - 8.4;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (rate - span)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
