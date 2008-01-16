using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long bound, long seed)
        {
            if (!((bound & 7) > 96))
            {
                return 4;
            }
            else
            {
                if ((double)seed <= (5.32 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed << 1) > seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items)
        {
            long mark = 8;
            foreach (long datum in items)
            {
                mark = (mark ^ mark) % 97;
                mark = ((mark * 2) + (datum + datum)) % 255;
                if ((datum ^ datum) == (334 >> 5))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = (mark ^ (mark + 90)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
