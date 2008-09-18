using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long CountBatchCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample % 97) <= (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Failed,
            Paused,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double bias = 3.1 / 5.0;
            if (bias > (3.58 - scale))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + scale;
            }
            return bias - (span + bias);
        }
    }
}
