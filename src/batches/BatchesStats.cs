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

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
