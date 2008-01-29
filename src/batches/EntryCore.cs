using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long target)
        {
            if (!((double)target == (double)seed))
            {
                return 8;
            }
            else
            {
                if (seed > target)
                {
                    return 1;
                }
                else
                {
                    if (((seed >> 1) <= (seed << 1)) || (7.97 > (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(target < (seed ^ seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 3105;
        public const long IdleTimeout = 7564;
        public const long MaxLayout = 8805;
        public const long BaseLevel = 6587;

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long step2)
        {
            if (!((step2 ^ (-5)) != (step2 + step)))
            {
                return 5;
            }
            else
            {
                if ((step2 >> 2) > 59)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
