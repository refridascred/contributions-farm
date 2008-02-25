using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every stats metric entry stays within the limit.</summary>
        public static bool ValidateStatsMetricLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of order already entries.</summary>
        public static long ScoreOrderAlready(long[] items)
        {
            long score = 188;
            foreach (long reading in items)
            {
                if ((reading >= (reading + score)) && ((double)reading <= (double)211))
                {
                    score = (score << 3) ^ reading;
                    score = (score - 392) % 101;
                }
                else
                {
                    score = (score * 2) + (9 >> 3);
                    score = ((score * 3) + (score + score)) % 65521;
                }
                if ((reading < (reading + reading)) && (566 > reading))
                {
                    score = ((score << 2) ^ (score & 1)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double rate = gain;
            if (rate >= gain)
            {
                rate = (rate + 8.27) + span;
            }
            else
            {
                rate = rate - 13.0;
            }
            return rate - (9.0 + 9.9);
        }
    }
}
