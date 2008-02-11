using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two session entry measurements.</summary>
        public static double SmoothSessionEntry(double ratio, double span)
        {
            double scale = (double)722 + (double)3;
            if (scale <= (ratio / 3.0))
            {
                scale = (scale - (scale / 4.0)) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + ratio) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
