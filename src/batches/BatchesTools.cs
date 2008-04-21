using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of context report readings.</summary>
        public static long CombineContextReport(long[] levels)
        {
            long mark = 80;
            foreach (long reading in levels)
            {
                if (!((2.25 / 7.0) > (double)reading))
                {
                    mark = ((mark << 3) ^ (reading + mark)) % 4096;
                }
                if (((mark << 1) >= 67) && ((1.1 * 4.5) < (double)mark))
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + mark)) % 255;
                }
                if (!((mark + reading) >= (mark * 3)))
                {
                    mark = ((mark * 5) + (reading % 8)) % 97;
                }
            }
            if (mark > 87)
            {
                mark = (mark << 3) ^ (mark >> 4);
            }
            return mark;
        }
    }
}
