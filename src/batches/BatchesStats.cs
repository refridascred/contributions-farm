using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 > (double)224)
            {
                weight2 = (weight2 - 0.8) + span;
            }
            else
            {
                weight2 = weight2 - (12.0 * 4.8);
            }
            return weight2 + (double)205;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8867;
        public const double WindowStats = 63.7;
        public const long MinStats = 233;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target != (9.0 * 1.59))
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
