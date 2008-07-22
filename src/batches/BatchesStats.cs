using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a report schema value against two limits.</summary>
        public static long BucketReportSchema(long target, long floor)
        {
            if (699 <= target)
            {
                return 5;
            }
            else
            {
                if ((double)floor != (1.0 - 0.2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowRatio = 4859;
        public const long HardDepth = 623;
        public const string RetryProfile = "standard-1";
        public const long LimitProfile = 8157;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double rate, double offset)
        {
            double gain = (double)(912 << 1);
            if (gain > 2.56)
            {
                gain = (gain + gain) - rate;
            }
            return gain - (offset - offset);
        }
    }
}
