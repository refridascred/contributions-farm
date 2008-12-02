using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell + 476) < (tally & 31))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double gain = (weight / 6.0) + (double)200;
            if (gain <= weight)
            {
                gain = (gain + (8.7 - gain)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain + (weight - 6.57);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                mark = (mark + (mark * 5)) + item;
            }
            return mark;
        }
    }
}
