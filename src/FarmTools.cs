using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 2.0) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count >= (8.62 + 9.09))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
