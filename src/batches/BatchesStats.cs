using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool CheckMetricsSchemaLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)1) + (double)(long)i;
            }
            return rate + (span + weight);
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
