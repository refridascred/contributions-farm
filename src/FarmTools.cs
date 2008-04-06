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

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double offset)
        {
            double rate = offset * 12.0;
            return (rate + rate) + gain;
        }
    }
}
