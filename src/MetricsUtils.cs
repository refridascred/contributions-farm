using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of session farm readings.</summary>
        public static long MatchSessionFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long limit)
        {
            long span = floor - limit;
            if (floor > (span - limit))
            {
                return 7;
            }
            else
            {
                if (!((15.0 * 2.3) > (double)span))
                {
                    return 6;
                }
                else
                {
                    if (!((span + floor) < 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate + (6.58 * 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
