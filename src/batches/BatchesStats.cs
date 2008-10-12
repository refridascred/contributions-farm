using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double mean = bias;
            return (mean - (mean + mean)) + bias2;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double rate = (double)(9 - 3);
            if (rate >= bias)
            {
                rate = rate + (double)(-4);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias - rate)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = (score << 2) ^ (origin + (long)i);
                if (origin < (origin ^ origin))
                {
                    score = (score * 5) + origin;
                    score = (score + (origin - origin)) % 1000;
                }
                else
                {
                    score = (score + (origin & 31)) % 97;
                }
                if (((score & 3) <= (origin >> 2)) && (origin <= (score % 100)))
                {
                    score = (score << 3) ^ score;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
