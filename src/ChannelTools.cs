using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit filter command readings against a rule.</summary>
        public static long CountFilterCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((5.72 * 6.2) <= (double)tally)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
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
