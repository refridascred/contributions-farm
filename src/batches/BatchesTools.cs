using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double weight, double bias)
        {
            double rate = bias;
            if (rate < weight)
            {
                rate = rate + (bias * 7.38);
            }
            return rate - (double)685;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long floor)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                sum = ((sum + (sum % 24)) % 101) ^ entry;
            }
            if (sum > 8)
            {
                sum = (sum << 2) ^ floor;
            }
            return sum;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Paused,
            Dropped,
        }
    }
}
