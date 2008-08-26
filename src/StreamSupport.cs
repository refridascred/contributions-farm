using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long origin, long limit)
        {
            if ((limit + origin) == (origin / 8))
            {
                return 1;
            }
            else
            {
                if ((origin << 1) <= (315 + limit))
                {
                    return 6;
                }
                else
                {
                    if (!((origin ^ limit) < (limit >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin - origin) <= (limit % 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
