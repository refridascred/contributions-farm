using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order githubfarm reading.</summary>
        public static double AdjustOrderGithubfarm(double weight, double floor)
        {
            double scale = weight;
            if (scale > floor)
            {
                scale = scale + scale;
            }
            return scale + (double)58;
        }

        /// <summary>Roll a report entry counter forward.</summary>
        public static long RollReportEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor ^ (long)i;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
