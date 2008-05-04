using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long bound, long limit)
        {
            long offset = bound + limit;
            if ((offset % 10) > bound)
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (offset + bound))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset != (4.3 * 5.0)) && ((offset + offset) <= (offset - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - limit) < (bound + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > (mark + mark))
                {
                    mark = ((mark * 2) + (mark & 127)) % 101;
                }
                else
                {
                    mark = (mark ^ mark) % 255;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
