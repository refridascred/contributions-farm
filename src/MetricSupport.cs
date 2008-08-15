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

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitFactor = 88.55;
        public const long IdleQueue = 3701;
        public const long BaseSize = 212;

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
