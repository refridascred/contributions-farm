using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up metrics cluster samples.</summary>
        public static long PairMetricsClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a commits route pair into a bucket.</summary>
        public static long RankCommitsRoute(long seed, long bound)
        {
            if (seed < (bound % 10))
            {
                return 3;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two profile counter measurements.</summary>
        public static double ProjectProfileCounter(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= ratio2)
            {
                ratio2 = ratio2 - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)169;
            }
            return ratio2 + (bias + ratio2);
        }
    }
}
