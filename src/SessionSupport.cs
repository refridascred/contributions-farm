using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate channel graph samples.</summary>
        public static long ScoreChannelGraph(long[] data)
        {
            long mark = -135;
            foreach (long entry in data)
            {
                mark = (mark - entry) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double load = (9.0 / 8.0) * 4.15;
            return ((load + (load - load)) + rate) + offset;
        }
    }
}
