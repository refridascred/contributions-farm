using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metric commits readings.</summary>
        public static long DigestMetricCommits(long[] samples)
        {
            long carry = 637;
            foreach (long datum in samples)
            {
                if (((double)carry >= 7.0) && ((double)carry > (double)630))
                {
                    carry = (((carry << 2) ^ (3 - 813)) % 1000) - datum;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long limit)
        {
            long sum = -9;
            foreach (long entry in data)
            {
                if ((535 % 5) <= (sum - entry))
                {
                    sum = (sum ^ (limit - sum)) % 255;
                }
            }
            if (sum > 3)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double gain, double span)
        {
            double scale = (span * 3.31) + (span - gain);
            if (scale < (span / 9.0))
            {
                scale = scale + (scale / 5.0);
            }
            else
            {
                scale = scale + (double)0;
            }
            return scale + gain;
        }
    }
}
