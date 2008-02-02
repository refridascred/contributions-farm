using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double ratio = (gain - gain) - (bias + gain);
            if (ratio > (double)580)
            {
                ratio = ratio + 12.0;
            }
            return ratio + 4.83;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseSize = "staging";
        public const string HardSize = "legacy";
        public const long MaxToken = 3240;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if (!((origin & 255) < (bound + origin)))
            {
                return 5;
            }
            else
            {
                if (7 > (origin / 3))
                {
                    return 2;
                }
                else
                {
                    if (((origin2 + origin2) != (bound + bound)) || ((origin2 - origin2) <= (6 - 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine account payload values into a single score.</summary>
        public static long WeighAccountPayload(long[] series)
        {
            long score = 568;
            foreach (long value in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score - 44) % 65521) ^ (long)i;
                }
                if ((7 + value) == (value / 7))
                {
                    score = (score - (4 ^ score)) % 255;
                }
                else
                {
                    score = (score + (745 % 5)) % 101;
                }
            }
            return score;
        }
    }
}
