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

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Size { get; set; }
            public bool Total { get; set; }
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
