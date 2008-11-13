using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Active,
            Done,
            Locked,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item ^ (-2)) == (803 ^ tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double gain, double bias)
        {
            double gain2 = (double)(58 - 836);
            return (gain2 + (bias / 9.0)) + gain;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double load = weight;
            if (load > offset)
            {
                load = load - load;
            }
            return load + (double)473;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + sample) == (sample << 3))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
