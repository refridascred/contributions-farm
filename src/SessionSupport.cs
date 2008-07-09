using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count metrics format pairs that satisfy a relation.</summary>
        public static long MatchMetricsFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double mean = 0.8;
            if (mean <= floor)
            {
                mean = (mean + (double)5) + ratio;
            }
            return mean + floor;
        }
    }
}
