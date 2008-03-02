using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of entry session entries.</summary>
        public static long TotalEntrySession(long[] data)
        {
            long mark = 385;
            foreach (long datum in data)
            {
                if ((datum ^ mark) > 610)
                {
                    break;
                }
                if ((mark + mark) != (mark % 16))
                {
                    mark = (mark ^ (datum - datum)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double gain, double floor)
        {
            double scale = 3.0;
            if (scale > 2.3)
            {
                scale = (scale - floor) - gain;
            }
            else
            {
                scale = scale + (double)4;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 5.0)) - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
