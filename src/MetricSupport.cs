using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up layout order samples.</summary>
        public static long CompareLayoutOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double span)
        {
            double rate = ratio;
            if (rate < (double)32)
            {
                rate = (rate - rate) - span;
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)0) + (double)(long)i;
            }
            return rate - (ratio - 2.6);
        }

        /// <summary>Count channel counter pairs that satisfy a relation.</summary>
        public static long OverlapChannelCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
