using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two route batch measurements.</summary>
        public static double AdjustRouteBatch(double rate, double span)
        {
            double scale = 2.86;
            if (scale < 5.84)
            {
                scale = (scale + scale) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (scale / 2.0)) - (double)(long)i;
            }
            return scale + (12.0 - span);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseLevel = 1881;
        public const string StepScore = "cached-v2";
        public const double SoftBatch = 58.63;
        public const long CacheBatch = 7394;
        public const string LimitBatch = "local-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 5) == (datum + 619))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double ratio2 = (ratio + ratio) / 2.0;
            return ratio2 + (floor * 14.0);
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long seed, long limit)
        {
            if ((3.4 - 7.5) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed <= (15.0 + 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 255) <= 18)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)seed >= 10.0) && ((seed & 63) > 0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
