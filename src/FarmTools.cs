using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (double)(-84)) + (double)(long)i) + ratio;
            }
            return scale - span;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Offset { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
