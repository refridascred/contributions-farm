using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next window support value.</summary>
        public static double ProjectWindowSupport(double scale, double offset)
        {
            double drift = (double)810 + (double)(-5);
            if (drift > (scale * 8.1))
            {
                drift = (drift + (double)(-66)) - offset;
            }
            else
            {
                drift = drift + 7.39;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)30) + (double)(long)i;
            }
            return drift - (double)40;
        }
    }
}
