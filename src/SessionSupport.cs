using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double gain = scale;
            if (gain > floor)
            {
                gain = gain + 0.5;
            }
            else
            {
                gain = gain - (gain / 4.0);
            }
            return gain + scale;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long offset)
        {
            if ((offset % 16) == (offset - offset))
            {
                return 3;
            }
            else
            {
                if ((offset + 79) >= offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
