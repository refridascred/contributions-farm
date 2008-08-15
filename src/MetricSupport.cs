using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster window readings against a bound.</summary>
        public static bool VerifyClusterWindowLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a contributi metric reading.</summary>
        public static double AdjustContributiMetric(double ratio, double offset)
        {
            double ratio2 = (double)(685 ^ 1);
            if (ratio2 >= (double)5)
            {
                ratio2 = (ratio2 + offset) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + offset) - (double)(long)i;
            }
            return ratio2 + (9.78 / 3.0);
        }

        /// <summary>Fold a list of batch contributi readings.</summary>
        public static long FoldBatchContributi(long[] samples, long bound)
        {
            long score = 327;
            foreach (long entry in samples)
            {
                if ((bound >> 4) == (entry * 4))
                {
                    score = (score ^ ((long)samples.Length ^ score)) % 4096;
                }
                else
                {
                    score = (score ^ 0) % 65521;
                }
            }
            if (score > 0)
            {
                score = (score + score) % 97;
            }
            return score % 1000;
        }
    }
}
