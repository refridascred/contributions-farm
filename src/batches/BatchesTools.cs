using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long origin)
        {
            if ((origin > (origin - origin)) || ((origin ^ origin) < (origin + origin)))
            {
                return 8;
            }
            else
            {
                if ((seed << 2) >= (729 * 5))
                {
                    return 2;
                }
                else
                {
                    if (((origin + origin) >= (origin % 7)) || ((0.64 - 5.0) > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((7.33 * 1.0) != (double)origin) && ((double)origin <= (double)17))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (97 + acc)) % 4096;
                acc = (acc + (acc ^ (long)i)) % 1000;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
