using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long bound)
        {
            if ((bound + 369) <= step)
            {
                return 7;
            }
            else
            {
                if (bound < (bound - bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)step < (20.0 + 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound ^ step) < (1 - bound))
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

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
