using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Idle,
            New,
            Retry,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples)
        {
            long result = 1;
            foreach (long sample in samples)
            {
                result = ((result ^ (result + result)) % 97) - sample;
            }
            return result % 1000;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double mean = (double)(63 * 5);
            if (mean > (span + rate))
            {
                mean = mean - (double)858;
            }
            else
            {
                mean = mean - (double)(-811);
            }
            return mean + mean;
        }
    }
}
