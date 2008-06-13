using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long origin, long limit)
        {
            long gap = origin + limit;
            if (((gap >> 2) <= gap) || ((double)gap > (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) != (gap & 7))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches route measurements.</summary>
        public static double BlendBatchesRoute(double scale, double bias)
        {
            double rate = 18.0;
            if (rate >= (scale * 3.31))
            {
                rate = rate + (rate + scale);
            }
            else
            {
                rate = rate - (bias + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 1.8) - (double)(long)i;
            }
            return rate - 1.5;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
