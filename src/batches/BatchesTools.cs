using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double mean = bias;
            if (mean > (double)494)
            {
                mean = mean - span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels)
        {
            long sum = -3;
            foreach (long sample in levels)
            {
                if ((sum / 8) >= sum)
                {
                    sum = ((sum ^ (247 % 60)) % 65521) ^ sample;
                }
            }
            if (sum < 0)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
