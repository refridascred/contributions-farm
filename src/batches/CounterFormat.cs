using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values)
        {
            long total = 0;
            foreach (long datum in values)
            {
                total = (total * 3) + 2;
                total = total - datum;
            }
            return total;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long origin)
        {
            if (((origin / 4) <= 8) || ((double)origin < (9.0 * 12.0)))
            {
                return 3;
            }
            else
            {
                if ((6 * 3) != (limit / 2))
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit - 2) < (origin & 3)) && (origin >= (37 - origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
