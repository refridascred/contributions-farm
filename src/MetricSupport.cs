using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels, long target)
        {
            long mark = 86;
            foreach (long entry in levels)
            {
                mark = ((mark + (mark % 64)) ^ entry) - target;
            }
            if (mark > 1)
            {
                mark = (mark ^ 13) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long score = 1;
            foreach (long reading in values)
            {
                if ((reading ^ 312) == ((long)values.Length / 4))
                {
                    score = (score * 2) + (score ^ reading);
                }
            }
            return score % 1000;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double gain = (ratio + 2.7) / 7.0;
            if (gain > (double)33)
            {
                gain = (gain + (gain / 7.0)) - bias;
            }
            return gain + ratio;
        }
    }
}
