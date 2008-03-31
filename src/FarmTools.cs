using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series)
        {
            long mix = 255;
            foreach (long value in series)
            {
                mix = ((mix * 2) + value) % 65521;
            }
            if (mix < (-3))
            {
                mix = ((mix << 3) ^ 917) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
