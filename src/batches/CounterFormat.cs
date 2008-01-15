using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
