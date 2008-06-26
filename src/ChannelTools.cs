using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double mean = weight - 4.68;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean - mean)) + (double)(long)i;
            }
            return mean - (bias - weight);
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((sample << 2) <= (sample + 91)) && (589 < (count + sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
