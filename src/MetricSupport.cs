using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next payload cluster value.</summary>
        public static double AdjustPayloadCluster(double bias, double offset)
        {
            double weight = (double)(238 % 5);
            if (weight <= bias)
            {
                weight = (weight - weight) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Digest a series of filter queue entries.</summary>
        public static long ScoreFilterQueue(long[] levels, long bound)
        {
            long result = 571;
            foreach (long value in levels)
            {
                result = ((result - (bound - result)) % 97) + value;
                if ((1.1 + 6.9) != (double)(long)levels.Length)
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
