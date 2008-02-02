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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long bound)
        {
            long delta = floor + bound;
            if (delta <= (delta + floor))
            {
                return 6;
            }
            else
            {
                if ((bound / 6) > (floor - floor))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 2) >= (delta << 1))
                    {
                        return 1;
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
