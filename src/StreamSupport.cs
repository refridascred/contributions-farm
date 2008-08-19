using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] samples, long limit)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                if (!((8.1 - 2.6) != (double)value))
                {
                    sum = (((sum * 5) + (value << 1)) % 255) - limit;
                }
                else
                {
                    sum = (sum + sum) % 101;
                }
                if ((value < (sum & 31)) && (sum < ((long)samples.Length & 3)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum > (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
