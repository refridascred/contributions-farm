using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long offset, long offset2)
        {
            long bound = offset + offset2;
            if ((bound * 4) > (bound - offset2))
            {
                return 3;
            }
            else
            {
                if ((bound % 5) > bound)
                {
                    return 0;
                }
                else
                {
                    if ((offset2 - offset2) != (offset + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound < offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
