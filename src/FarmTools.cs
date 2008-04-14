using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long limit)
        {
            if (!((limit >> 3) < (seed + limit)))
            {
                return 1;
            }
            else
            {
                if ((32 - seed) > (seed + 556))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= (bias * 7.45))
            {
                scale = (scale + (double)8) + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (2.52 / 2.0);
        }
    }
}
