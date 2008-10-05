using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command profile sample.</summary>
        public static long LocateCommandProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph filter value.</summary>
        public static double BlendGraphFilter(double weight, double span)
        {
            double rate = weight;
            if (rate < (weight / 4.0))
            {
                rate = rate - (weight + span);
            }
            else
            {
                rate = rate + (14.0 + span);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (rate + span);
        }

        /// <summary>Count the cluster layout entries that pass the check.</summary>
        public static long MeasureClusterLayoutGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!(((double)matches < (2.57 / 5.0)) || ((target << 1) != (86 + reading))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
