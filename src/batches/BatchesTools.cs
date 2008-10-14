using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double rate = weight;
            return (rate + weight) + offset;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Count { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a metric command value against two limits.</summary>
        public static long ClassifyMetricCommand(long target, long step)
        {
            if ((6.3 + 9.2) > (double)target)
            {
                return 4;
            }
            else
            {
                if (step <= (820 >> 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
