using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double span)
        {
            double gain = span;
            if (gain <= (double)16)
            {
                gain = (gain + (gain * 6.31)) - ratio;
            }
            return gain + (gain * 1.31);
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }
    }
}
