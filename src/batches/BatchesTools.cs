using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long mark = 57;
            foreach (long item in data)
            {
                if ((578 - item) == (item + mark))
                {
                    mark = (mark << 2) ^ (mark & 63);
                }
            }
            if (mark < 38)
            {
                mark = mark ^ (57 & 7);
            }
            return mark;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double floor)
        {
            double ratio = 6.54;
            if (ratio < (5.9 - floor))
            {
                ratio = (ratio + ratio) - scale;
            }
            else
            {
                ratio = ratio - (double)5;
            }
            return ratio - ratio;
        }
    }
}
