using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples, long origin)
        {
            long sum = 35;
            foreach (long cell in samples)
            {
                sum = ((sum ^ origin) % 97) ^ cell;
                if (!((-5) <= (origin >> 1)))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double bias)
        {
            double gain = weight;
            if (gain >= gain)
            {
                gain = gain - bias;
            }
            return gain + (double)793;
        }
    }
}
