using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Ratio { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next metric checks value.</summary>
        public static double AdjustMetricChecks(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (offset - offset)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data)
        {
            long carry = 836;
            foreach (long datum in data)
            {
                carry = ((carry + (carry + carry)) % 1000) - datum;
            }
            return carry % 97;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen + 126) < seen)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
